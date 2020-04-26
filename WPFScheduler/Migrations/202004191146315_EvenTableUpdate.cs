namespace WPFScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EvenTableUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
