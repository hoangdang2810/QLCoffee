namespace QLCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_all5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "Tonggia", c => c.String());
            DropColumn("dbo.Bills", "DanhGia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bills", "DanhGia", c => c.String());
            DropColumn("dbo.Bills", "Tonggia");
        }
    }
}
