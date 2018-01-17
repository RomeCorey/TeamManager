namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apiTournament : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tournaments", "lat", c => c.String());
            AddColumn("dbo.Tournaments", "lng", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tournaments", "lng");
            DropColumn("dbo.Tournaments", "lat");
        }
    }
}
