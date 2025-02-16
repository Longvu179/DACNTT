namespace MobiSell.Services.VNpayService
{
    public class VNPayRequestDTO
    {
        public string OrderType { get; set; }
        public double Amount { get; set; }
        public string OrderDescription { get; set; }
        public string Name { get; set; }
    }
}
