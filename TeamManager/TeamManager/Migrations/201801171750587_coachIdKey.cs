namespace TeamManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coachIdKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CoachNotes");
            AddColumn("dbo.CoachNotes", "coachNoteId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String());
            AddPrimaryKey("dbo.CoachNotes", "coachNoteId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CoachNotes");
            AlterColumn("dbo.CoachNotes", "coachNotes", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.CoachNotes", "coachNoteId");
            AddPrimaryKey("dbo.CoachNotes", "coachNotes");
        }
    }
}
