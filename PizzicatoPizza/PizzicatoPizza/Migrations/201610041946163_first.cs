namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Couriers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Status = c.Int(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Photo = c.String(),
                        Language = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Int(nullable: false),
                        Image = c.String(),
                        Category = c.Int(nullable: false),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id)
                .Index(t => t.Pizza_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address = c.String(),
                        OrderTime = c.Int(nullable: false),
                        Client_Id = c.Int(),
                        Courier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Client_Id)
                .ForeignKey("dbo.Couriers", t => t.Courier_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Courier_Id);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Int(nullable: false),
                        Image = c.String(),
                        Count = c.Int(nullable: false),
                        Size_Id = c.Int(),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sizes", t => t.Size_Id)
                .ForeignKey("dbo.Orders", t => t.Order_Id)
                .Index(t => t.Size_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Diameter = c.Int(nullable: false),
                        Coefficient = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pizzas", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Pizzas", "Size_Id", "dbo.Sizes");
            DropForeignKey("dbo.Ingredients", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.Orders", "Courier_Id", "dbo.Couriers");
            DropForeignKey("dbo.Orders", "Client_Id", "dbo.Users");
            DropForeignKey("dbo.Couriers", "User_Id", "dbo.Users");
            DropIndex("dbo.Pizzas", new[] { "Order_Id" });
            DropIndex("dbo.Pizzas", new[] { "Size_Id" });
            DropIndex("dbo.Orders", new[] { "Courier_Id" });
            DropIndex("dbo.Orders", new[] { "Client_Id" });
            DropIndex("dbo.Ingredients", new[] { "Pizza_Id" });
            DropIndex("dbo.Couriers", new[] { "User_Id" });
            DropTable("dbo.Sizes");
            DropTable("dbo.Pizzas");
            DropTable("dbo.Orders");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Users");
            DropTable("dbo.Couriers");
        }
    }
}
