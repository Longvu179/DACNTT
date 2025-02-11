using Microsoft.AspNetCore.Mvc;
using MobiSell.Services;
using MobiSell.Services.VNpayService;

namespace MobiSell.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly VNPayService _vnPayService;

        public PaymentController(VNPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost("create-payment")]
        public IActionResult CreatePayment([FromBody] VNPayRequestDto request)
        {
            var returnUrl = Url.Action("PaymentCallback", "Payment", null, Request.Scheme);
            var paymentUrl = _vnPayService.CreatePaymentUrl(request, returnUrl);
            return Ok(new { PaymentUrl = paymentUrl });
        }

        [HttpGet("payment-callback")]
        public IActionResult PaymentCallback()
        {
            var queryCollection = HttpContext.Request.Query;
            if (_vnPayService.ValidatePayment(queryCollection, out var orderId))
            {
                // Xử lý thanh toán thành công
                return Ok(new { Message = "Payment successful", OrderId = orderId });
            }

            // Xử lý thanh toán thất bại
            return BadRequest(new { Message = "Payment failed" });
        }
    }

}
