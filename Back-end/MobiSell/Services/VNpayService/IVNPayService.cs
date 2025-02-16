namespace MobiSell.Services.VNpayService
{
    public interface IVNPayService
    {
        string CreatePaymentUrl(VNPayRequestDTO model, HttpContext context);
        VNPayResponeDTO PaymentExecute(IQueryCollection collections);

    }
}
