namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateData : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CoachNotes");
            AddColumn("dbo.CoachNotes", "playerName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String());
            AddPrimaryKey("dbo.CoachNotes", "playerName");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CoachNotes");
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.CoachNotes", "playerName");
            AddPrimaryKey("dbo.CoachNotes", "coachNotes");
        }
    }
}
