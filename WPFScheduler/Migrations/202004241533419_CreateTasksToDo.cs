namespace WPFScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTasksToDo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskToDoes",
                c => new
                    {
                        TaskToDoID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Deadline = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TaskToDoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskToDoes");
        }
    }
}
