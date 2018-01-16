namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latLongAddToPractice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TeamPractices", "lat", c => c.String());
            AddColumn("dbo.TeamPractices", "lng", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TeamPractices", "lng");
            DropColumn("dbo.TeamPractices", "lat");
        }
    }
}
