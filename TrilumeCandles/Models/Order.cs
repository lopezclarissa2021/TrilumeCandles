using System.ComponentModel.DataAnnotations;

namespace TrilumeCandles.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OrderStatus { get; set; }
        public string ShippingAddress { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
