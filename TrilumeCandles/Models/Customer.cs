using System.ComponentModel.DataAnnotations;

namespace TrilumeCandles.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
    }
}
