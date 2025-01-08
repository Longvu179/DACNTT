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
    public class Product_ImageController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public Product_ImageController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Product_Image
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_Image>>> GetProduct_Images()
        {
            return await _context.Product_Images.ToListAsync();
        }

        // GET: api/Product_Image/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_Image>> GetProduct_Image(int id)
        {
            var product_Image = await _context.Product_Images.FindAsync(id);

            if (product_Image == null)
            {
                return NotFound();
            }

            return product_Image;
        }

        // PUT: api/Product_Image/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Image(int id, Product_Image product_Image)
        {
            if (id != product_Image.Id)
            {
                return BadRequest();
            }

            _context.Entry(product_Image).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_ImageExists(id))
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

        // POST: api/Product_Image
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_Image>> PostProduct_Image(Product_Image product_Image)
        {
            _context.Product_Images.Add(product_Image);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_Image", new { id = product_Image.Id }, product_Image);
        }

        // DELETE: api/Product_Image/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_Image(int id)
        {
            var product_Image = await _context.Product_Images.FindAsync(id);
            if (product_Image == null)
            {
                return NotFound();
            }

            _context.Product_Images.Remove(product_Image);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Product_ImageExists(int id)
        {
            return _context.Product_Images.Any(e => e.Id == id);
        }
    }
}
