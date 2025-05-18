using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO
{
    public class Food
    {
        public Food()
        {
            OrderItems = new HashSet<OrderItem>();
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int FoodId { get; set; }
        [Required()]
        public string FoodName { get; set; }
        [Required()]
        public double Price { get; set; }
        public int Quantity { get; set; } = 1;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
