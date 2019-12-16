namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Type : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AdmissionTests", "StudentId", "dbo.Students");
            DropIndex("dbo.AdmissionTests", new[] { "StudentId" });
            AddColumn("dbo.Students", "AdmissionTestId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "AdmissionTests_Id", c => c.Int());
            CreateIndex("dbo.Students", "AdmissionTests_Id");
            AddForeignKey("dbo.Students", "AdmissionTests_Id", "dbo.AdmissionTests", "Id");
            DropColumn("dbo.AdmissionTests", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdmissionTests", "StudentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "AdmissionTests_Id", "dbo.AdmissionTests");
            DropIndex("dbo.Students", new[] { "AdmissionTests_Id" });
            DropColumn("dbo.Students", "AdmissionTests_Id");
            DropColumn("dbo.Students", "AdmissionTestId");
            CreateIndex("dbo.AdmissionTests", "StudentId");
            AddForeignKey("dbo.AdmissionTests", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
