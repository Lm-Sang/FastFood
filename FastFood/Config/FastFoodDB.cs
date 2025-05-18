namespace FastFood.Config
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FastFoodDB : DbContext
    {
        public FastFoodDB()
            : base("name=FastFood")
        {
            Database.SetInitializer(new DBCreate());
        }
        public virtual DbSet<DTO.Account> Accounts { get; set; }
        public virtual DbSet<DTO.Food> Foods { get; set; }
        public virtual DbSet<DTO.Order> Orders { get; set; }
        public virtual DbSet<DTO.OrderItem> OrderItems { get; set; }

    }
}