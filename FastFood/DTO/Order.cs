using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string Status { get; set; } = "PENDING";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
