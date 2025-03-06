using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MobiSell.Data;
using MobiSell.Models;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public ReviewsController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            return await _context.Reviews.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        [HttpGet("getByProduct/{productId}")]
        public async Task<ActionResult<IEnumerable<Review>>> GetByProduct(int productId)
        {
            var reviews = await _context.Reviews
                .Where(w => w.ProductId == productId).OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return Ok(reviews);
        }
        [HttpGet("getByOrder/{orderId}")]
        public async Task<ActionResult<IEnumerable<Review>>> GetByOrder(int orderId)
        {
            var reviews = await _context.Reviews.Where(w => w.OrderId == orderId).ToListAsync();
            return Ok(reviews);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateReviews([FromBody] List<Review> reviews)
        {
            if (reviews == null)
            {
                return BadRequest("Danh sách đánh giá không hợp lệ.");
            }

            foreach (var review in reviews)
            {
                var existingReview = await _context.Reviews
                    .FirstOrDefaultAsync(r => r.Id == review.Id);

                if (existingReview == null)
                {
                    return NotFound($"Không tìm thấy đánh giá với ID: {review.Id}");
                }

                // Cập nhật thông tin đánh giá
                existingReview.Rating = review.Rating;
                existingReview.Comment = review.Comment;

                _context.Reviews.Update(existingReview);
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Lỗi khi cập nhật đánh giá.");
            }

            return Ok("Đánh giá đã được cập nhật thành công.");
        }

        [HttpPost]
        public async Task<ActionResult<Review>> PostReviews(List<Review> reviews)
        {
            if (reviews == null || reviews.Count == 0)
            {
                return BadRequest("Danh sách đánh giá không hợp lệ.");
            }
            
            var order = await _context.Orders.FindAsync(reviews[0].OrderId);
            if (order != null)
            {
                order.IsRate = true;
                _context.Entry(order).State = EntityState.Modified;
            }

            foreach (var review in reviews)
            {
                review.CreatedAt = DateTime.Now;
                review.LastUpdatedAt = DateTime.Now;
            }

            await _context.Reviews.AddRangeAsync(reviews);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostReviews), new { success = "Đánh giá đã được lưu thành công." });
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}
