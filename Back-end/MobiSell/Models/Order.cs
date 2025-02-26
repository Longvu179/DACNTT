namespace MobiSell.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverNumber { get; set; }
        public string ShippingAddress { get; set; }
        public int? VoucherId { get; set; }
        public Voucher Voucher { get; set; }
        public int TotalQuantity { get; set; }
        public double DiscountPrice { get; set; }
        public double OrderTotal { get; set; }
        public OrderStatus Status { get; set; }
        public PaymentMethod Payment { get; set; }
        public bool IsPaid { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CancelDate { get; set; }
    }

    public enum PaymentMethod
    {
        COD,
        VNpay
    }

    public enum OrderStatus
    {
        Processing,    // Đang xử lý
        Shipped,       // Đã giao cho đơn vị vận chuyển
        Delivered,     // Đã giao hàng
        Cancelled      // Đã hủy
    }
}
