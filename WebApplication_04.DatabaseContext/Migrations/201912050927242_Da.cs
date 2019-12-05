namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Da : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MajorOfBusinesses", "Marketing1st", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfBusinesses", "Marketing2nd", c => c.Int(nullable: false));
            DropColumn("dbo.MajorOfBusinesses", "Economics1st");
            DropColumn("dbo.MajorOfBusinesses", "Economics2nd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MajorOfBusinesses", "Economics2nd", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfBusinesses", "Economics1st", c => c.Int(nullable: false));
            DropColumn("dbo.MajorOfBusinesses", "Marketing2nd");
            DropColumn("dbo.MajorOfBusinesses", "Marketing1st");
        }
    }
}
