﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;
using MobiSell.Services;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MobiSellContext _context;
        private readonly IFileService _fileService;

        public ProductsController(MobiSellContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            product.DayCreate = DateTime.Now;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Product>>> SearchProduct(string keyword)
        {
            return await _context.Products.Where(p => p.Name.Contains(keyword)).ToListAsync();
        }

        [HttpPost("addToCart")]
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
            else if(item.Quantity < product.Quantity)
            {
                item.Quantity++;
                item.UpdateAt = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                return NoContent();
            }
            return NoContent();
        }

        [HttpDelete("removeFromCart")]
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

        [HttpPost("wishlist")]
        public async Task<ActionResult<WishList>> WishList(string userId, int productId)
        {
            var wishList = await _context.WishLists.FirstOrDefaultAsync(w => w.UserId == userId && w.ProductId == productId);
            if (wishList == null)
            {
                var newWishList = new WishList()
                {
                    UserId = userId,
                    ProductId = productId,
                    CreatedAt = DateTime.UtcNow,
                };

                _context.WishLists.Add(newWishList);
                await _context.SaveChangesAsync();
                return Ok("Add to wishlist success!");
            }
            _context.WishLists.Remove(wishList);
            await _context.SaveChangesAsync();
            return Ok("Un wishlist success!");
        }
    }
}
