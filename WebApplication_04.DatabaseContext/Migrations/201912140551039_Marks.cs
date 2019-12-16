namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "TotalMarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "TotalMarks");
        }
    }
}
