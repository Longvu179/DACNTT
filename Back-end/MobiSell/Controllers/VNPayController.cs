using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobiSell.Data;
using MobiSell.Services;
using MobiSell.Services.VNpayService;

namespace MobiSell.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IVNPayService _vnPayService;
        private readonly MobiSellContext _context;
        public PaymentController(IVNPayService vnPayService, MobiSellContext context)
        {
            _vnPayService = vnPayService;
            _context = context;
        }
        [HttpPost("create-payment")]
        public IActionResult CreatePaymentUrlVnpay(VNPayRequestDTO model)
        {
            var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }
        [HttpGet("payment-callback")]
        public async Task<IActionResult> PaymentCallbackVnpay()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);

            if (response != null && response.Success)
            {
                var orderInfor = response.OrderDescription.Split(" ");
                var orderId = orderInfor[orderInfor.Length - 1];
                var order = await _context.Orders.FindAsync(int.Parse(orderId));
                if (order == null)
                {
                    return NotFound("Order not found.");
                }

                order.IsPaid = true;

                await _context.SaveChangesAsync();
                return Ok(response);
            }

            return BadRequest("Payment failed or invalid response.");
        }

    }

}
