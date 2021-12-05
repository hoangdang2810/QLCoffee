namespace QLCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ALL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        CoffeeID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CoffeeName = c.String(),
                        TinhChat = c.String(),
                        SoLuong = c.String(),
                        DonVi = c.String(),
                        TheTich = c.String(),
                        NguonGoc = c.String(),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.CoffeeID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CustomerName = c.String(unicode: false),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employment",
                c => new
                    {
                        EmploymentID = c.String(nullable: false, maxLength: 50, unicode: false),
                        EmploymentName = c.String(unicode: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.EmploymentID);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        CoffeeID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CoffeeName = c.String(),
                        TinhChat = c.String(),
                        SoLuong = c.String(),
                        DonVi = c.String(),
                        TheTich = c.String(),
                        NguonGoc = c.String(),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.CoffeeID);
            
            CreateTable(
                "dbo.Price",
                c => new
                    {
                        CoffeeID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CoffeeName = c.String(),
                        TinhChat = c.String(),
                        SoLuong = c.String(),
                        DonVi = c.String(),
                        TheTich = c.String(),
                        NguonGoc = c.String(),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.CoffeeID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierID = c.String(nullable: false, maxLength: 50, unicode: false),
                        SupplierName = c.String(unicode: false),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Account");
            DropTable("dbo.Supplier");
            DropTable("dbo.Price");
            DropTable("dbo.Inventory");
            DropTable("dbo.Employment");
            DropTable("dbo.Customer");
            DropTable("dbo.Bills");
        }
    }
}
