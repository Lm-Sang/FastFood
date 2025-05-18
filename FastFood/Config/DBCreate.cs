using FastFood.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Config
{
    class DBCreate : CreateDatabaseIfNotExists<FastFoodDB>
    {
        protected override void Seed(FastFoodDB context)
        {
            context.Accounts.Add(new Account()
            {
                AccountId = 1,
                Username = "admin",
                Password = BCrypt.Net.BCrypt.EnhancedHashPassword("admin"),
                Role = "ADMIN",
                Name = "ADMIN"
            });
            base.Seed(context);
        }
    }
}
