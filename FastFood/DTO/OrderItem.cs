using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DTO
{
    public class OrderItem
    {
        public OrderItem()
        {
            CreatedAt = DateTime.Now;
        }
        [Key]
        public int OrderItemId { get; set; }
        public int FoodId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [DefaultValue(1)]
        public int Quantity { get; set; } = 1;
        [NotMapped]
        public double TotalPrice
        {
            get
            {
                if (Food != null)
                {
                    return Food.Price * Quantity;
                }
                return 0;
            }
        }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
