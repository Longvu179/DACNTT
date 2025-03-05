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
using MobiSell.Services;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product_SKUController : ControllerBase
    {
        private readonly MobiSellContext _context;
        private readonly IFileService _fileService;

        public Product_SKUController(MobiSellContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
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
        
        [HttpGet("getByProduct/{productId}")]
        public async Task<ActionResult<IEnumerable<Product_SKU>>> GetByProductId(int productId)
        {
            var product_SKU = await _context.Product_SKUs.Where(p => p.ProductId.Equals(productId)).ToListAsync();

            if (product_SKU == null)
            {
                return NotFound();
            }

            return product_SKU;
        }

        // PUT: api/Product_SKU/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutProduct_SKU(int id,
            [FromForm] Product_SKU product_SKU,
            [FromForm] IEnumerable<IFormFile> images)
        {
            if (!Product_SKUExists(id))
            {
                return NotFound();
            }
            var default_product_SKU = await _context.Product_SKUs.FindAsync(id);

            default_product_SKU.SKU = product_SKU.SKU;
            default_product_SKU.RAM_ROM = product_SKU.RAM_ROM;
            default_product_SKU.Color = product_SKU.Color;
            default_product_SKU.DefaultPrice = product_SKU.DefaultPrice;
            default_product_SKU.DiscountPercentage = product_SKU.DiscountPercentage;
            default_product_SKU.FinalPrice = product_SKU.FinalPrice;
            default_product_SKU.Quantity = product_SKU.Quantity;
            default_product_SKU.Sold = product_SKU.Sold;
            default_product_SKU.Default = product_SKU.Default;
            default_product_SKU.IsAvailable = product_SKU.IsAvailable;
            default_product_SKU.LastUpdatedAt = DateTime.UtcNow;


            if (images != null && images.Any())
            {
                var newImage = images.FirstOrDefault();

                if (newImage != null && default_product_SKU.ImageName != newImage.FileName)
                {
                    var imageNames = await _fileService.SaveFilesAsync(images, default_product_SKU.ProductId);
                    await _fileService.DeleteFileAsync(default_product_SKU.ProductId + "/" + default_product_SKU.ImageName);
                    default_product_SKU.ImageName = imageNames[0];
                }
            }

            _context.Entry(default_product_SKU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Product_SKU>> PostProduct_SKU(
            [FromForm] Product_SKU product_SKU,
            [FromForm] IEnumerable<IFormFile> images)
        {
            var imageNames = await _fileService.SaveFilesAsync(images, product_SKU.ProductId);

            product_SKU.ImageName = imageNames[0];
            _context.Product_SKUs.Add(product_SKU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_SKU", new { id = product_SKU.Id }, product_SKU);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
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

        [HttpPost("addToCart")]
        [Authorize]
        public async Task<ActionResult<Cart_Item>> AddToCart(int cartId, int product_SKUId)
        {
            var item = await _context.Cart_Items.FirstOrDefaultAsync(i => i.CartId == cartId && i.Product_SKUId == product_SKUId);
            var product = await _context.Product_SKUs.FindAsync(product_SKUId);
            if (item == null)
            {
                var cartItem = new Cart_Item()
                {
                    CartId = cartId,
                    Product_SKUId = product_SKUId,
                    Quantity = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdateAt = DateTime.UtcNow
                };

                _context.Cart_Items.Add(cartItem);
                await _context.SaveChangesAsync();
                return Ok("Add to cart success!");
            }
            else if (item.Quantity < product.Quantity)
            {
                item.Quantity++;
                item.UpdateAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            return NoContent();
        }

        [HttpDelete("removeFromCart")]
        [Authorize]
        public async Task<IActionResult> RemoveFromCart(int cartId, int product_SKUId)
        {
            var item = await _context.Cart_Items.FirstOrDefaultAsync(i => i.CartId == cartId && i.Product_SKUId == product_SKUId);
            if (item == null)
            {
                return NotFound();
            }

            _context.Cart_Items.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
