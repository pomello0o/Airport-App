namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdminRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Admin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Admin");
        }
    }
}
