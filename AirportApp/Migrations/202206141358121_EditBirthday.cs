namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditBirthday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Birthday", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
