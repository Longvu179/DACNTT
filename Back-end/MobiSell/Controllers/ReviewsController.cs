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

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            _context.Entry(review).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Review>> PostReviews(List<Review> reviews)
        {
            if (reviews == null || reviews.Count == 0)
            {
                return BadRequest("Danh sách đánh giá không hợp lệ.");
            }
            var item = await _context.Order_Items.FindAsync(reviews[0].Order_ItemId);
            if(item != null)
            {
                var order = await _context.Orders.FindAsync(item.OrderId);
                if (order != null)
                {
                    order.IsRate = true;
                    _context.Entry(order).State = EntityState.Modified;
                }
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
