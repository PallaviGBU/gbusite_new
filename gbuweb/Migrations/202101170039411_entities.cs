namespace gbuweb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                        createdAt = c.DateTime(nullable: false),
                        photo = c.String(),
                        type = c.String(),
                        school = c.String(),
                        pdf = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entities");
        }
    }
}
