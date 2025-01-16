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
    public class Product_SKUController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public Product_SKUController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Product_SKU
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_SKU>>> GetProduct_SKUs()
        {
            return await _context.Product_SKUs.ToListAsync();
        }

        // GET: api/Product_SKU/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_SKU>> GetProduct_SKU(int id)
        {
            var product_SKU = await _context.Product_SKUs.FindAsync(id);

            if (product_SKU == null)
            {
                return NotFound();
            }

            return product_SKU;
        }

        // PUT: api/Product_SKU/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_SKU(int id, Product_SKU product_SKU)
        {
            if (id != product_SKU.Id)
            {
                return BadRequest();
            }

            _context.Entry(product_SKU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_SKUExists(id))
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

        // POST: api/Product_SKU
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_SKU>> PostProduct_SKU(Product_SKU product_SKU)
        {
            _context.Product_SKUs.Add(product_SKU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_SKU", new { id = product_SKU.Id }, product_SKU);
        }

        // DELETE: api/Product_SKU/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_SKU(int id)
        {
            var product_SKU = await _context.Product_SKUs.FindAsync(id);
            if (product_SKU == null)
            {
                return NotFound();
            }

            _context.Product_SKUs.Remove(product_SKU);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Product_SKUExists(int id)
        {
            return _context.Product_SKUs.Any(e => e.Id == id);
        }
    }
}
