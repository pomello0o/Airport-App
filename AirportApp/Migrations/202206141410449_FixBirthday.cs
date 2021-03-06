namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBirthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Birthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
