using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MobiSell.Models;
using Microsoft.CodeAnalysis;

namespace MobiSell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public LocationController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET: api/location/cities  
        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/location.json");
            Console.WriteLine("path" + filePath);
            if (!System.IO.File.Exists(filePath)) return NotFound("File not found.");

            var json = await System.IO.File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<City>>(json);

            var cities = data?.Select(c => new { c.Id, c.Name }).ToList();
            return Ok(cities);
        }

        // GET: api/location/districts/{cityId}  
        [HttpGet("districts/{cityId}")]
        public async Task<IActionResult> GetDistricts(string cityId)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/location.json");
            var json = await System.IO.File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<City>>(json);

            var city = data?.FirstOrDefault(c => c.Id == cityId);
            if (city == null) return NotFound("City not found.");

            var districts = city.Districts.Select(d => new { d.Id, d.Name }).ToList();
            return Ok(districts);
        }

        // GET: api/location/wards/{cityId}/{districtId}  
        [HttpGet("wards/{cityId}/{districtId}")]
        public async Task<IActionResult> GetWards(string cityId, string districtId)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data/location.json");
            var json = await System.IO.File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<City>>(json);

            var district = data?.FirstOrDefault(c => c.Id == cityId)?.Districts.FirstOrDefault(d => d.Id == districtId);
            if (district == null) return NotFound("District not found.");

            var wards = district.Wards.Select(w => new { w.Id, w.Name }).ToList();
            return Ok(wards);
        }
    }

}
