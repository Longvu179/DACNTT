using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Models;

[Route("api/[controller]")]
[ApiController]
public class RevenueController : ControllerBase
{
    private readonly MobiSellContext _context;

    public RevenueController(MobiSellContext context)
    {
        _context = context;
    }

    // 1️⃣ Thống kê doanh thu theo ngày
    [HttpGet("daily")]
    public async Task<IActionResult> GetDailyRevenue(DateTime date)
    {
        var paid = await _context.Orders.Where(o => o.IsPaid && o.OrderDate.Date == date.Date).ToListAsync();
        var revenue = paid.Sum(o => o.OrderTotal);

        var unPaid = await _context.Orders.Where(o => !o.IsPaid && o.OrderDate.Date == date.Date).ToListAsync();
        var unPaidTotal = unPaid.Sum(o => o.OrderTotal);

        var processing = await _context.Orders.Where(o => o.Status == OrderStatus.Processing && o.OrderDate.Date == date.Date).ToListAsync();
        var shipped = await _context.Orders.Where(o => o.Status == OrderStatus.Shipped && o.OrderDate.Date == date.Date).ToListAsync();
        var delivered = await _context.Orders.Where(o => o.Status == OrderStatus.Delivered && o.OrderDate.Date == date.Date).ToListAsync();
        var cancelled = await _context.Orders.Where(o => o.Status == OrderStatus.Cancelled && o.OrderDate.Date == date.Date).ToListAsync();

        return Ok(new { Date = date.ToShortDateString(), 
            Revenue = revenue, 
            numberOfPaid = paid.Count, 
            UnPaid = unPaidTotal, 
            numberOfUnPaid = unPaid.Count,
            Processing = processing.Count,
            Shipped = shipped.Count,
            Delivered = delivered.Count,
            Cancelled = cancelled.Count
        });
    }
    
    [HttpGet("monthly")]
    public async Task<IActionResult> GetMonthlyRevenue(int year, int month)
    {
        var paid = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();
        var revenue = paid.Sum(o => o.OrderTotal);
        
        var unPaid = await _context.Orders
            .Where(o => !o.IsPaid && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();
        var unPaidTotal = unPaid.Sum(o => o.OrderTotal);

        var processing = await _context.Orders
            .Where(o => o.Status == OrderStatus.Processing && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();
        var shipped = await _context.Orders
            .Where(o => o.Status == OrderStatus.Shipped && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();
        var delivered = await _context.Orders
            .Where(o => o.Status == OrderStatus.Delivered && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();
        var cancelled = await _context.Orders
            .Where(o => o.Status == OrderStatus.Cancelled && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .ToListAsync();

        return Ok(new { 
            Year = year, 
            Month = month, 
            Revenue = revenue, 
            numberOfPaid = paid.Count, 
            UnPaid = unPaidTotal, 
            numberOfUnPaid = unPaid.Count,
            Processing = processing.Count,
            Shipped = shipped.Count,
            Delivered = delivered.Count,
            Cancelled = cancelled.Count
        });
    }

    // 3️⃣ Thống kê doanh thu theo năm
    [HttpGet("yearly")]
    public async Task<IActionResult> GetYearlyRevenue(int year)
    {
        var paid = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Year == year)
            .ToListAsync();
        var revenue = paid.Sum(o => o.OrderTotal);

        var unPaid = await _context.Orders
            .Where(o => !o.IsPaid && o.OrderDate.Year == year)
            .ToListAsync();
        var unPaidTotal = unPaid.Sum(o => o.OrderTotal);

        var processing = await _context.Orders
            .Where(o => o.Status == OrderStatus.Processing && o.OrderDate.Year == year)
            .ToListAsync();
        var shipped = await _context.Orders
            .Where(o => o.Status == OrderStatus.Shipped && o.OrderDate.Year == year)
            .ToListAsync();
        var delivered = await _context.Orders
            .Where(o => o.Status == OrderStatus.Delivered && o.OrderDate.Year == year)
            .ToListAsync();
        var cancelled = await _context.Orders
            .Where(o => o.Status == OrderStatus.Cancelled && o.OrderDate.Year == year)
            .ToListAsync();

        return Ok(new { 
            Year = year, 
            Revenue = revenue, 
            numberOfPaid = paid.Count, 
            UnPaid = unPaidTotal, 
            numberOfUnPaid = unPaid.Count,
            Processing = processing.Count,
            Shipped = shipped.Count,
            Delivered = delivered.Count,
            Cancelled = cancelled.Count
        });
    }

    // 4️⃣ Thống kê doanh thu trong khoảng thời gian
    [HttpGet("range")]
    public async Task<IActionResult> GetRevenueInRange(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
        {
            return BadRequest("Ngày bắt đầu phải trước hoặc bằng ngày kết thúc.");
        }

        var paid = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();
        var revenue = paid.Sum(o => o.OrderTotal);

        var unPaid = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();
        var unPaidTotal = unPaid.Sum(o => o.OrderTotal);

        var processing = await _context.Orders
            .Where(o => o.Status == OrderStatus.Processing && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();
        var shipped = await _context.Orders
            .Where(o => o.Status == OrderStatus.Shipped && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();
        var delivered = await _context.Orders
            .Where(o => o.Status == OrderStatus.Delivered && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();
        var cancelled = await _context.Orders
            .Where(o => o.Status == OrderStatus.Cancelled && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .ToListAsync();

        return Ok(new { 
            StartDate = startDate.ToShortDateString(), 
            EndDate = endDate.ToShortDateString(),
            Revenue = revenue, 
            numberOfPaid = paid.Count, 
            UnPaid = unPaidTotal, 
            numberOfUnPaid = unPaid.Count,
            Processing = processing.Count,
            Shipped = shipped.Count,
            Delivered = delivered.Count,
            Cancelled = cancelled.Count
        });
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllRevenue()
    {
        var paid = await _context.Orders.Where(o => o.IsPaid).ToListAsync();
        var revenue = paid.Sum(o => o.OrderTotal);

        var unPaid = await _context.Orders.Where(o => !o.IsPaid).ToListAsync();
        var unPaidTotal = unPaid.Sum(o => o.OrderTotal);

        var processing = await _context.Orders.Where(o => o.Status == OrderStatus.Processing).ToListAsync();
        var shipped = await _context.Orders.Where(o => o.Status == OrderStatus.Shipped).ToListAsync();
        var delivered = await _context.Orders.Where(o => o.Status == OrderStatus.Delivered).ToListAsync();
        var cancelled = await _context.Orders.Where(o => o.Status == OrderStatus.Cancelled).ToListAsync();

        return Ok(new { 
            Revenue = revenue, 
            numberOfPaid = paid.Count, 
            UnPaid = unPaidTotal, 
            numberOfUnPaid = unPaid.Count,
            Processing = processing.Count,
            Shipped = shipped.Count,
            Delivered = delivered.Count,
            Cancelled = cancelled.Count
        });
    }
}
