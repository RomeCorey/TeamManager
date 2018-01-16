namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coachNotes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoachNotes",
                c => new
                    {
                        coachNotes = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.coachNotes);
            
            AddColumn("dbo.TeamPractices", "practiceIndoor", c => c.String());
            AddColumn("dbo.TeamPractices", "practiceOutdoor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamPractices", "practiceOutdoor");
            DropColumn("dbo.TeamPractices", "practiceIndoor");
            DropTable("dbo.CoachNotes");
        }
    }
}
