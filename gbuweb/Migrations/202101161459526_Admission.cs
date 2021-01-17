namespace gbuweb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admission : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Programs", "level", c => c.String());
            AlterColumn("dbo.Programs", "feelink", c => c.String());
            AlterColumn("dbo.Programs", "coursestructurelink", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Programs", "coursestructurelink", c => c.Int(nullable: false));
            AlterColumn("dbo.Programs", "feelink", c => c.Int(nullable: false));
            DropColumn("dbo.Programs", "level");
        }
    }
}
