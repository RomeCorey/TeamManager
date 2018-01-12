namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationsForAllNewMVC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoachPayments",
                c => new
                    {
                        coachPaymentId = c.Int(nullable: false, identity: true),
                        amountProOwes = c.Double(nullable: false),
                        amountD2Owes = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.coachPaymentId);
            
            CreateTable(
                "dbo.ScoutingEvents",
                c => new
                    {
                        scoutingEventId = c.Int(nullable: false, identity: true),
                        rivalTeam = c.String(),
                        scoutingField = c.String(),
                        scoutingTime = c.String(),
                        scoutingNotes = c.String(),
                    })
                .PrimaryKey(t => t.scoutingEventId);
            
            CreateTable(
                "dbo.TeamDinners",
                c => new
                    {
                        teamDinnerId = c.Int(nullable: false, identity: true),
                        teamDinnerTime = c.String(),
                        teamDinnerLocation = c.String(),
                    })
                .PrimaryKey(t => t.teamDinnerId);
            
            CreateTable(
                "dbo.TeamMeetings",
                c => new
                    {
                        teamMeetingId = c.Int(nullable: false, identity: true),
                        teamMeetingLocation = c.String(),
                        teamMeetingTime = c.String(),
                        teamMeetingDate = c.String(),
                    })
                .PrimaryKey(t => t.teamMeetingId);
            
            CreateTable(
                "dbo.TeamPractices",
                c => new
                    {
                        teamPracticeId = c.Int(nullable: false, identity: true),
                        practiceLocation = c.String(),
                        practicePrice = c.Double(nullable: false),
                        indoor = c.Boolean(nullable: false),
                        outdoor = c.Boolean(nullable: false),
                        practiceTime = c.String(),
                    })
                .PrimaryKey(t => t.teamPracticeId);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        tournamentId = c.Int(nullable: false, identity: true),
                        tournamentLocation = c.String(),
                        tournamentTime = c.String(),
                        tournamentPrice = c.Double(nullable: false),
                        tournamentHotel = c.String(),
                    })
                .PrimaryKey(t => t.tournamentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tournaments");
            DropTable("dbo.TeamPractices");
            DropTable("dbo.TeamMeetings");
            DropTable("dbo.TeamDinners");
            DropTable("dbo.ScoutingEvents");
            DropTable("dbo.CoachPayments");
        }
    }
}
