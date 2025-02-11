namespace MobiSell.Services.VNpayService
{
    public class VNPayRequestDto
    {
        public string OrderId { get; set; }
        public decimal Amount { get; set; }
        public string OrderInfo { get; set; }
        public string IpAddress { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
