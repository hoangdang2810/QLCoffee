namespace QLCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_All3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Accounts");
            AlterColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Accounts", "UserName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Accounts");
            AlterColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.Accounts", "UserName");
        }
    }
}
