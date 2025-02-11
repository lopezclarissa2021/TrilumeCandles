using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrilumeCandles.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
        [Required]
        public ShippingAddress ShippingAddressId { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total must be greater than zero.")]
        public decimal Total { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
