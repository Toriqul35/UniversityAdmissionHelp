namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class to : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostAdmissions", "AdminId", "dbo.Admins");
            DropIndex("dbo.PostAdmissions", new[] { "AdminId" });
            DropColumn("dbo.PostAdmissions", "AdminId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostAdmissions", "AdminId", c => c.Int(nullable: false));
            CreateIndex("dbo.PostAdmissions", "AdminId");
            AddForeignKey("dbo.PostAdmissions", "AdminId", "dbo.Admins", "Id", cascadeDelete: true);
        }
    }
}
