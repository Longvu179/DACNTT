using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly MobiSellContext _context;

        public AddressController(MobiSellContext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.Address.ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await _context.Address.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }
        
        [HttpGet("getByUser/{userId}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Address>>> GetByUser(string userId)
        {
            var address = await _context.Address.Where(a => a.UserId.Equals(userId)).ToListAsync();

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.Id)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        [HttpPatch("setDefault/{id}")]
        [Authorize]
        public async Task<IActionResult> SetDefault(int id, string userId)
        {
            var addresses = await _context.Address.Where(a => a.UserId.Equals(userId)).ToListAsync();
            if (addresses == null)
            {
                return NotFound(new { message = "Not found user" });
            }

            var addressToSetDefault = addresses.FirstOrDefault(a => a.Id == id);
            if (addressToSetDefault == null)
            {
                return NotFound(new { message = "Not found add", addresses });
            }

            foreach (var addr in addresses)
            {
                addr.Default = false;
            }

            addressToSetDefault.Default = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Addresses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            var temp = await _context.Address.FirstOrDefaultAsync(a => a.UserId.Equals(address.UserId));
            if (temp == null) {
                address.Default = true;
            }
            _context.Address.Add(address);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress", new { id = address.Id }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var address = await _context.Address.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Address.Remove(address);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddressExists(int id)
        {
            return _context.Address.Any(e => e.Id == id);
        }
    }
}
