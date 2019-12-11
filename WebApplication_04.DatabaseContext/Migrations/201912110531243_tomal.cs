namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tomal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostAdmissions", "StartTest", c => c.DateTime());
            AddColumn("dbo.PostAdmissions", "EndTest", c => c.DateTime());
            AddColumn("dbo.PostAdmissions", "TotalSeat", c => c.Int(nullable: false));
            AlterColumn("dbo.PostAdmissions", "PostDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PostAdmissions", "PostDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.PostAdmissions", "TotalSeat");
            DropColumn("dbo.PostAdmissions", "EndTest");
            DropColumn("dbo.PostAdmissions", "StartTest");
        }
    }
}
