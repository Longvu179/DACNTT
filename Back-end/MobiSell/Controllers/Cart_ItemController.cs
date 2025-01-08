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
    public class Cart_ItemController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public Cart_ItemController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Cart_Item
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart_Item>>> GetCart_Items(int cartId)
        {
            return await _context.Cart_Items.Where(i => i.CartId == cartId).ToListAsync();
        }

        // GET: api/Cart_Item/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cart_Item>> GetCart_Item(int id)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);

            if (cart_Item == null)
            {
                return NotFound();
            }

            return cart_Item;
        }

        // PUT: api/Cart_Item/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCart_Item(int id, int amount)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            if (cart_Item == null)
            {
                return BadRequest();
            }

            if (amount < 1 && cart_Item.Quantity > 1)
            {
                cart_Item.Quantity -= 1;
            }
            else
            {
                cart_Item.Quantity += 1;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Cart_ItemExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart_Item(int id)
        {
            var cart_Item = await _context.Cart_Items.FindAsync(id);
            if (cart_Item == null)
            {
                return NotFound();
            }

            _context.Cart_Items.Remove(cart_Item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Cart_ItemExists(int id)
        {
            return _context.Cart_Items.Any(e => e.Id == id);
        }
    }
}
