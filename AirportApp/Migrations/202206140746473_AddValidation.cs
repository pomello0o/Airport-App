namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.User", "Password", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Password", c => c.Binary());
            AlterColumn("dbo.User", "Email", c => c.String(maxLength: 100));
        }
    }
}
