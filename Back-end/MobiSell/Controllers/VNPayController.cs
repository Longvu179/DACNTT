using Microsoft.AspNetCore.Mvc;
using MobiSell.Services;
using MobiSell.Services.VNpayService;

namespace MobiSell.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IVNPayService _vnPayService;
        public PaymentController(IVNPayService vnPayService)
        {

            _vnPayService = vnPayService;
        }
        [HttpPost("create-payment")]
        public IActionResult CreatePaymentUrlVnpay(VNPayRequestDTO model)
        {
            var url = _vnPayService.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }
        [HttpGet("payment-callback")]
        public IActionResult PaymentCallbackVnpay()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);

            return Ok(response);
        }

    }

}
