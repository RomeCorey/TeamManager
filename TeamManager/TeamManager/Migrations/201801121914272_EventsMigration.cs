namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        eventId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.eventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
