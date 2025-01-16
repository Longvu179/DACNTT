namespace MobiSell.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public VoucherType Type { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DiscountAmount { get; set; }
        public double? MinOrderAmount { get; set; }
        public double? MaxDiscountAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
    }

    public enum VoucherType
    {
        Percentage,
        Amount
    }
}
