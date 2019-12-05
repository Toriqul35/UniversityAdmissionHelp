namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Studentcul : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Day", c => c.String());
            AddColumn("dbo.Students", "Month", c => c.String());
            AddColumn("dbo.Students", "Year", c => c.String());
            DropColumn("dbo.Students", "DateOfBirth1");
            DropColumn("dbo.Students", "DateOfBirth");
            DropColumn("dbo.Students", "ConfrimPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ConfrimPassword", c => c.String());
            AddColumn("dbo.Students", "DateOfBirth", c => c.DateTime());
            AddColumn("dbo.Students", "DateOfBirth1", c => c.String());
            DropColumn("dbo.Students", "Year");
            DropColumn("dbo.Students", "Month");
            DropColumn("dbo.Students", "Day");
        }
    }
}
