namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class da : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostAdmissions", "PostAdmission_Id", "dbo.PostAdmissions");
            DropIndex("dbo.PostAdmissions", new[] { "PostAdmission_Id" });
            DropColumn("dbo.PostAdmissions", "PostAdmission_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostAdmissions", "PostAdmission_Id", c => c.Int());
            CreateIndex("dbo.PostAdmissions", "PostAdmission_Id");
            AddForeignKey("dbo.PostAdmissions", "PostAdmission_Id", "dbo.PostAdmissions", "Id");
        }
    }
}
