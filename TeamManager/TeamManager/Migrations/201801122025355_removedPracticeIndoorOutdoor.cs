namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedPracticeIndoorOutdoor : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TeamPractices", "indoor");
            DropColumn("dbo.TeamPractices", "outdoor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TeamPractices", "outdoor", c => c.String());
            AddColumn("dbo.TeamPractices", "indoor", c => c.String());
        }
    }
}
