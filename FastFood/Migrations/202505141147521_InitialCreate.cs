namespace FastFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountDTOes",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.OrderDTOes",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        CustomerPhoneNumber = c.String(),
                        Status = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AccountDTOes", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.OrderItemDTOes",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        FoodId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.FoodDTOes", t => t.FoodId, cascadeDelete: true)
                .ForeignKey("dbo.OrderDTOes", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.FoodId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.FoodDTOes",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FoodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItemDTOes", "OrderId", "dbo.OrderDTOes");
            DropForeignKey("dbo.OrderItemDTOes", "FoodId", "dbo.FoodDTOes");
            DropForeignKey("dbo.OrderDTOes", "AccountId", "dbo.AccountDTOes");
            DropIndex("dbo.OrderItemDTOes", new[] { "OrderId" });
            DropIndex("dbo.OrderItemDTOes", new[] { "FoodId" });
            DropIndex("dbo.OrderDTOes", new[] { "AccountId" });
            DropTable("dbo.FoodDTOes");
            DropTable("dbo.OrderItemDTOes");
            DropTable("dbo.OrderDTOes");
            DropTable("dbo.AccountDTOes");
        }
    }
}
