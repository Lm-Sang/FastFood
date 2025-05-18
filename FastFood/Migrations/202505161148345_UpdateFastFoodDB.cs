using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Data.Entity;
namespace FastFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFastFoodDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AccountDTOes", newName: "Accounts");
            RenameTable(name: "dbo.OrderDTOes", newName: "Orders");
            RenameTable(name: "dbo.OrderItemDTOes", newName: "OrderItems");
            RenameTable(name: "dbo.FoodDTOes", newName: "Foods");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Foods", newName: "FoodDTOes");
            RenameTable(name: "dbo.OrderItems", newName: "OrderItemDTOes");
            RenameTable(name: "dbo.Orders", newName: "OrderDTOes");
            RenameTable(name: "dbo.Accounts", newName: "AccountDTOes");
        }
    }
}
