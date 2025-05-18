using FastFood.Config;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace FastFood.DAL
{
    public class OrderDAL
    {
        private static readonly FastFoodDB db = new FastFoodDB();

        public void CreateNewOrder(Order order, List<FindOrderItem> findorderItem)
        {
            Account account = db.Accounts.FirstOrDefault(a => a.AccountId == Session.UserId);
            if (account == null)
            {
                throw new Exception("Account not found!");
            }
            order.Account = account;
            db.Orders.Add(order);
            db.SaveChanges();
            order.OrderItems = new List<OrderItem>();
            foreach (var item in findorderItem)
            {
                Food food = db.Foods.FirstOrDefault(f => f.FoodId == item.ID);
                if (food == null)
                {
                    throw new Exception("Food not found!");
                }
                OrderItem orderItem = new OrderItem
                {
                    FoodId = food.FoodId,
                    Quantity = item.Quantity,
                    Order = order,
                };
                food.Quantity -= item.Quantity;
                db.OrderItems.Add(orderItem);
            }
            db.SaveChanges();
        }

        public int UpdateOrderStatus(int orderId, string status)
        {
            Order order = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                throw new Exception("Order not found!");
            }
            order.Status = status;
            return db.SaveChanges();
        }

        public List<FindOrder> GetOrderByDateTime(DateTime start, DateTime end, int accountId)
        {
            List<FindOrder> orders = db.Orders.Include("Account").Include("OrderItems.Food")
                .Where(o => o.CreatedAt >= start && o.CreatedAt <= end && (accountId == -1 || o.AccountId == accountId))
                .ToList()
                .Select(o => new FindOrder
                {
                    OrderId = o.OrderId,
                    StaffName = o.Account.Name,
                    CustomerName = o.CustomerName,
                    CustomerPhoneNumber = o.CustomerPhoneNumber,
                    Status = o.Status,
                    CreatedAt = o.CreatedAt,
                    TotalPrice = o.OrderItems.Sum(oi => oi.TotalPrice)
                }).ToList();

            return orders;
        }

        public int DeleteOrder(Order order)
        {
            Order existingOrder = db.Orders.FirstOrDefault(f => f.OrderId == order.OrderId);
            if (existingOrder != null)
            {
                db.Orders.Remove(existingOrder);
                return db.SaveChanges();
            }
            else
            {
                throw new Exception("Food not found");
            }
        }
    }
}
