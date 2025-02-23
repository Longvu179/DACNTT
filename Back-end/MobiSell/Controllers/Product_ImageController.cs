using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class Product_ImageController : ControllerBase
    {
        private readonly MobiSellContext _context;
        private readonly IFileService _fileService;

        public Product_ImageController(MobiSellContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
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
        
        [HttpGet("getByProduct/{productId}")]
        public async Task<ActionResult<IEnumerable<Product_Image>>> GetByProductId(int productId)
        {
            var product_Image = await _context.Product_Images.Where(p => p.ProductId.Equals(productId)).ToListAsync();

            if (product_Image == null)
            {
                return NotFound();
            }

            return product_Image;
        }

        // PUT: api/Product_Image/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Image(int id, 
            [FromForm] Product_Image product_Image,
            [FromForm] IEnumerable<IFormFile> images)
        {
            if (!Product_ImageExists(id))
            {
                return NotFound();
            }
            var default_product_Image = await _context.Product_Images.FindAsync(id);

            if(images != null)
            {
                if(default_product_Image.ImageName != images.FirstOrDefault().FileName)
                {
                    var imageNames = await _fileService.SaveFilesAsync(images, default_product_Image.ProductId);
                    await _fileService.DeleteFileAsync(default_product_Image.ProductId + "/" + default_product_Image.ImageName);
                    default_product_Image.ImageName = imageNames[0];
                }                
            }

            _context.Entry(default_product_Image).State = EntityState.Modified;

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

        // POST: api/Product_Image
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product_Image>> PostProduct_Image(List<IFormFile> images, int productId)
        {
            var imageNames = await _fileService.SaveFilesAsync(images, productId);
            foreach (var imageName in imageNames)
            {
                var product_Image = new Product_Image
                {
                    ProductId = productId,
                    ImageName = imageName,
                    IsMain = false,
                    CreatedAt = DateTime.Now
                };
                _context.Product_Images.Add(product_Image);
            }
            await _context.SaveChangesAsync();

            return Ok(imageNames);
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
            await _fileService.DeleteFileAsync(product_Image.ProductId + "/" + product_Image.ImageName);

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
