namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MajorOfBusinesses", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MajorOfBusinesses", "Date");
        }
    }
}
