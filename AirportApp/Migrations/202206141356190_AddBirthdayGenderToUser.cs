namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayGenderToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Gender");
            DropColumn("dbo.User", "Birthday");
        }
    }
}
