using FastFood.DAL;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class OrderBLL
    {
        private static readonly OrderDAL od = new OrderDAL();
        public ResponseDTO AddNewOrder(string name, string phoneNumber, List<FindOrderItem> findorderitem)
        {
            try
            {
                if (findorderitem == null || findorderitem.Count == 0)
                {
                    return new ResponseDTO
                    {
                        success = false,
                        message = "Cannot find orderitem in the order",
                        data = null
                    };
                }

                var order = new Order
                {
                    CustomerName = string.IsNullOrEmpty(name) ? "Unknown" : name,
                    CustomerPhoneNumber = string.IsNullOrEmpty(phoneNumber) ? "Unknown" : phoneNumber
                };

                od.CreateNewOrder(order, findorderitem);

                return new ResponseDTO
                {
                    success = true,
                    message = "Order created successfully",
                    data = null
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }

        public ResponseDTO UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                int result = od.UpdateOrderStatus(orderId, status);

                if (result == 0)
                {
                    throw new Exception("Update order failed");
                }

                return new ResponseDTO
                {
                    success = true,
                    message = "Update order status successfully",
                    data = null
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }

        public ResponseDTO GetOrderByDateTime(int accountId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var orders = od.GetOrderByDateTime(startDate, endDate, accountId);

                return new ResponseDTO
                {
                    success = true,
                    message = "Get orders successfully",
                    data = orders
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }

        public ResponseDTO DeleteOrder(Order order)
        {
            try
            {
                bool isDelete = od.DeleteOrder(order) > 0;
                return new ResponseDTO
                {
                    success = isDelete,
                    message = isDelete ? "Delete order successfully" : "Delete order failed",
                    data = null,
                };
            }
            catch (Exception e)
            {
                return new ResponseDTO
                {
                    success = false,
                    message = e.Message,
                    data = null
                };
            }
        }
    }
}
