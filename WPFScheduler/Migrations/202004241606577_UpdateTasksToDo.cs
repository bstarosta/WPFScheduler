namespace WPFScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTasksToDo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TaskToDoes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TaskToDoes", "Type");
        }
    }
}
