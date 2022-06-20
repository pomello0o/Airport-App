namespace AirportApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropSession : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Session", "UserID", "dbo.User");
            DropIndex("dbo.Session", new[] { "UserID" });
            DropTable("dbo.Session");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Session", "UserID");
            AddForeignKey("dbo.Session", "UserID", "dbo.User", "ID", cascadeDelete: true);
        }
    }
}
