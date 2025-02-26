using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public OrdersController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
        
        [HttpGet("getByUser/{userId}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderByUser(string userId)
        {
            var order = await _context.Orders.Where(o => o.UserId.Equals(userId)).ToListAsync();

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<IActionResult> UpdateOrderStatusAsync(int id, OrderStatus newStatus)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
                return NotFound(new { message = "Không tìm thấy đơn hàng." });

            if (order.Status == OrderStatus.Delivered)
                return BadRequest(new { message = "Đơn hàng đã giao không thể thay đổi trạng thái." });

            if (order.Status == OrderStatus.Cancelled)
                return BadRequest(new { message = "Đơn hàng đã bị hủy không thể thay đổi trạng thái." });

            if (newStatus == OrderStatus.Cancelled && order.Status == OrderStatus.Delivered)
                return BadRequest(new { message = "Không thể hủy đơn hàng đã giao." });
            
            if (newStatus == OrderStatus.Cancelled && order.Status == OrderStatus.Shipped)
                return BadRequest(new { message = "Không thể hủy đơn hàng đã giao cho đơn vị vận chuyển." });

            if (order.Status == newStatus)
                return BadRequest(new { message = $"Đơn hàng đã ở trạng thái {newStatus}." });

            order.Status = newStatus;

            if (newStatus == OrderStatus.Cancelled)
                order.CancelDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(new { message = $"Cập nhật trạng thái đơn hàng thành {newStatus} thành công." });
        }

        [HttpPut("cancel/{id}")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            return await UpdateOrderStatusAsync(id, OrderStatus.Cancelled);
        }

        [HttpPut("ship/{id}")]
        public async Task<IActionResult> ShipOrder(int id)
        {
            return await UpdateOrderStatusAsync(id, OrderStatus.Shipped);
        }

        [HttpPut("deliver/{id}")]
        public async Task<IActionResult> DeliverOrder(int id)
        {
            return await UpdateOrderStatusAsync(id, OrderStatus.Delivered);
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
