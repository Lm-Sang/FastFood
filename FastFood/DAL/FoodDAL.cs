using FastFood.Config;
using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.DAL
{
    public class FoodDAL
    {
        private static readonly FastFoodDB db = new FastFoodDB();

        public int AddFood(Food food)
        {
            db.Foods.Add(food);
            return db.SaveChanges();
        }

        public int UpdateFood(Food food)
        {
            Food existingFood = db.Foods.FirstOrDefault(f => f.FoodId == food.FoodId);
            if (existingFood != null)
            {
                existingFood.FoodName = food.FoodName;
                existingFood.Price = food.Price;
                existingFood.Quantity = food.Quantity;
                return db.SaveChanges();
            }
            else
            {
                throw new Exception("Food not found");
            }
        }

        public int DeleteFood(Food food)
        {
            Food existingFood = db.Foods.FirstOrDefault(f => f.FoodId == food.FoodId);
            if (existingFood != null)
            {
                db.Foods.Remove(existingFood);
                return db.SaveChanges();
            }
            else
            {
                throw new Exception("Food not found");
            }
        }

        public List<FindFood> GetFoodByName(string name)
        {
            return db.Foods
                .Where(f => f.FoodName.Contains(name))
                .Select(f => new FindFood
                {
                    FoodId = f.FoodId,
                    FoodName = f.FoodName,
                    Price = f.Price,
                    Quantity = f.Quantity,
                    CreatedAt = f.CreatedAt
                }).ToList();
        }




    }
}
