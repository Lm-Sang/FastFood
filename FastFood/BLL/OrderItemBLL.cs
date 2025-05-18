using FastFood.DAL;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class OrderItemBLL
    {
        private static readonly OrderItemDAL oid = new OrderItemDAL();

        public ResponseDTO GetOrderItemByOrderId(int orderId)
        {
            try
            {
                var orderItems = oid.GetOrderItemByOrderId(orderId);

                if (orderItems == null || orderItems.Count == 0)
                {
                    return new ResponseDTO
                    {
                        success = false,
                        message = "No items found for this order.",
                        data = null
                    };
                }

                return new ResponseDTO
                {
                    success = true,
                    message = "Order items retrieved successfully.",
                    data = orderItems
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
