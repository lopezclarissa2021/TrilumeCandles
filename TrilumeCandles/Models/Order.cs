using System.ComponentModel.DataAnnotations;

namespace TrilumeCandles.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime DateTime { get; set; }
    }
}
