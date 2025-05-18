using FastFood.Config;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL
{
    public class OrderItemDAL
    {
        private static readonly FastFoodDB db = new FastFoodDB();

        public List<DetailOrderItem> GetOrderItemByOrderId(int orderId)
        {
            var orderItems = db.OrderItems
                .Include("Food")
                .Where(oi => oi.OrderId == orderId)
                .Select(oi => new DetailOrderItem
                {
                    OrderItemId = oi.OrderItemId,
                    FoodId = oi.FoodId,
                    FoodName = oi.Food.FoodName,
                    Quantity = oi.Quantity,
                    TotalPrice = oi.Quantity * oi.Food.Price
                })
                .ToList();
            return orderItems;
        }
    }
}
