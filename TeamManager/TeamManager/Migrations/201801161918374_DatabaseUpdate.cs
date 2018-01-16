namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "paymentId", "dbo.CoachPayments");
            DropIndex("dbo.Players", new[] { "paymentId" });
            DropColumn("dbo.CoachNotes", "players");
            DropColumn("dbo.Players", "paymentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "paymentId", c => c.Int(nullable: false));
            AddColumn("dbo.CoachNotes", "players", c => c.String());
            CreateIndex("dbo.Players", "paymentId");
            AddForeignKey("dbo.Players", "paymentId", "dbo.CoachPayments", "coachPaymentId", cascadeDelete: true);
        }
    }
}
