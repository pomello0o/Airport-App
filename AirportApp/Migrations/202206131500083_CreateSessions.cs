namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSessions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Session",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        DestroyedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Session", "UserID", "dbo.User");
            DropIndex("dbo.Session", new[] { "UserID" });
            DropTable("dbo.Session");
        }
    }
}
