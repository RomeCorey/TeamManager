namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTablesInDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamPractices", "practiceDate", c => c.String());
            AddColumn("dbo.Tournaments", "tournamentDates", c => c.String());
            AlterColumn("dbo.TeamPractices", "indoor", c => c.String());
            AlterColumn("dbo.TeamPractices", "outdoor", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TeamPractices", "outdoor", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TeamPractices", "indoor", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tournaments", "tournamentDates");
            DropColumn("dbo.TeamPractices", "practiceDate");
        }
    }
}
