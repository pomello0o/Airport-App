namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEmailUnique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.User", "Password", c => c.Binary());
            CreateIndex("dbo.User", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.User", new[] { "Email" });
            AlterColumn("dbo.User", "Password", c => c.Binary(nullable: false));
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
