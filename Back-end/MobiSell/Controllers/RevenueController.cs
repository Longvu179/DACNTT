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
    [HttpGet("isPaid/daily")]
    public async Task<IActionResult> GetDailyRevenue(DateTime date)
    {
        var revenue = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Date == date.Date)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Date = date.ToShortDateString(), Revenue = revenue });
    }
    [HttpGet("isntPaid/daily")]
    public async Task<IActionResult> GetDailyRevenueIsntPaid(DateTime date)
    {
        var revenue = await _context.Orders
            .Where(o => !o.IsPaid && o.OrderDate.Date == date.Date)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Date = date.ToShortDateString(), Revenue = revenue });
    }

    // 2️⃣ Thống kê doanh thu theo tháng
    [HttpGet("isPaid/monthly")]
    public async Task<IActionResult> GetMonthlyRevenue(int year, int month)
    {
        var revenue = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Year = year, Month = month, Revenue = revenue });
    }
    [HttpGet("isntPaid/monthly")]
    public async Task<IActionResult> GetMonthlyRevenueIsntPaid(int year, int month)
    {
        var revenue = await _context.Orders
            .Where(o => !o.IsPaid && o.OrderDate.Year == year && o.OrderDate.Month == month)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Year = year, Month = month, Revenue = revenue });
    }

    // 3️⃣ Thống kê doanh thu theo năm
    [HttpGet("isPaid/yearly")]
    public async Task<IActionResult> GetYearlyRevenue(int year)
    {
        var revenue = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Year == year)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Year = year, Revenue = revenue });
    }
    [HttpGet("isntPaid/yearly")]
    public async Task<IActionResult> GetYearlyRevenueIsntPaid(int year)
    {
        var revenue = await _context.Orders
            .Where(o => !o.IsPaid && o.OrderDate.Year == year)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { Year = year, Revenue = revenue });
    }

    // 4️⃣ Thống kê doanh thu trong khoảng thời gian
    [HttpGet("range")]
    public async Task<IActionResult> GetRevenueInRange(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
        {
            return BadRequest("Ngày bắt đầu phải trước hoặc bằng ngày kết thúc.");
        }

        var revenue = await _context.Orders
            .Where(o => o.IsPaid && o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date)
            .SumAsync(o => o.OrderTotal);

        return Ok(new { StartDate = startDate.ToShortDateString(), EndDate = endDate.ToShortDateString(), Revenue = revenue });
    }
}
