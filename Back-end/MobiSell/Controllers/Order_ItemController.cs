using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order_ItemController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public Order_ItemController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Order_Item
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Order_Item>>> GetOrder_Items()
        {
            return await _context.Order_Items.ToListAsync();
        }

        // GET: api/Order_Item/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Order_Item>> GetOrder_Item(int id)
        {
            var order_Item = await _context.Order_Items.FindAsync(id);

            if (order_Item == null)
            {
                return NotFound();
            }

            return order_Item;
        }
        [HttpGet("getByOrder/{orderId}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Order_Item>>> GetByOrderId(int orderId)
        {
            var order_Item = await _context.Order_Items.Where(o => o.OrderId.Equals(orderId)).ToListAsync();

            if (order_Item == null)
            {
                return NotFound();
            }

            return order_Item;
        }

        // PUT: api/Order_Item/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutOrder_Item(int id, Order_Item order_Item)
        {
            if (id != order_Item.Id)
            {
                return BadRequest();
            }

            _context.Entry(order_Item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_ItemExists(id))
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

        // POST: api/Order_Item
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Order_Item>> PostOrder_Item(Order_Item order_Item)
        {
            _context.Order_Items.Add(order_Item);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder_Item", new { id = order_Item.Id }, order_Item);
        }

        // DELETE: api/Order_Item/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteOrder_Item(int id)
        {
            var order_Item = await _context.Order_Items.FindAsync(id);
            if (order_Item == null)
            {
                return NotFound();
            }

            _context.Order_Items.Remove(order_Item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Order_ItemExists(int id)
        {
            return _context.Order_Items.Any(e => e.Id == id);
        }
    }
}
