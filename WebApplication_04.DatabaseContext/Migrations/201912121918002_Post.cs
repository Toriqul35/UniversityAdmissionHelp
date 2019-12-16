namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Post : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PostAdmissions", "Title");
            DropColumn("dbo.PostAdmissions", "FileName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostAdmissions", "FileName", c => c.String());
            AddColumn("dbo.PostAdmissions", "Title", c => c.String());
        }
    }
}
