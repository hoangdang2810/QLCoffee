namespace QLCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ALL2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        CoffeeID = c.String(nullable: false, maxLength: 50, unicode: false),
                        CoffeeName = c.String(),
                        SoLuong = c.String(),
                        TheTich = c.String(),
                        ThemTopping = c.String(),
                        DanhGia = c.String(),
                    })
                .PrimaryKey(t => t.CoffeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menu");
        }
    }
}
