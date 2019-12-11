namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdmissionTests", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.AdmissionTests", "StudentId");
            AddForeignKey("dbo.AdmissionTests", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdmissionTests", "StudentId", "dbo.Students");
            DropIndex("dbo.AdmissionTests", new[] { "StudentId" });
            DropColumn("dbo.AdmissionTests", "StudentId");
        }
    }
}
