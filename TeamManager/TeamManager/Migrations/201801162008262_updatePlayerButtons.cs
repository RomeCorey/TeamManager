namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePlayerButtons : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CoachNotes");
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CoachNotes", "coachNotes");
            DropColumn("dbo.CoachNotes", "playerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CoachNotes", "playerName", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.CoachNotes");
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String());
            AddPrimaryKey("dbo.CoachNotes", "playerName");
        }
    }
}
