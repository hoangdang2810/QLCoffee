namespace QLCoffee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ALL1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Account", newName: "Accounts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Accounts", newName: "Account");
        }
    }
}
