namespace MobiSell.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string CustomerName { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int? VoucherId { get; set; }
        public Voucher Voucher { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public string ShippingAddress { get; set; }
        public int OrderTotal { get; set; }
    }
}
