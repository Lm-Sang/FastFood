using FastFood.DAL;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BLL
{
    public class FoodBLL
    {
        private static readonly FoodDAL fd = new FoodDAL();
        public ResponseDTO AddFood(Food food)
        {
            try
            {
                bool isAdded = fd.AddFood(food) > 0;

                if (!isAdded)
                {
                    throw new Exception("Add food failed");
                }

                return new ResponseDTO
                {
                    success = true,
                    message = "Add food successfully",
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

        public ResponseDTO UpdateFood(Food food)
        {
            try
            {
                bool isUpdated = fd.UpdateFood(food) > 0;

                return new ResponseDTO
                {
                    success = isUpdated,
                    message = isUpdated ? "Update food successfully" : "Update food failed",
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

        public ResponseDTO GetFoodByName(string name)
        {
            try
            {
                var foods = fd.GetFoodByName(name);

                return new ResponseDTO
                {
                    success = true,
                    message = "Get food successfully",
                    data = foods
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

        public ResponseDTO DeleteFood(Food food)
        { 
            try
            {
                bool isDelete = fd.DeleteFood(food) > 0;
                return new ResponseDTO
                {
                    success = isDelete,
                    message = isDelete ? "Delete food successfully" : "Delete food failed",
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
