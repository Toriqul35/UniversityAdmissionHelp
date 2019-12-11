namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ad : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MajorOfBusinesses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.MajorOfHumanities", "StudentId", "dbo.Students");
            DropForeignKey("dbo.MajorOfSciences", "StudentId", "dbo.Students");
            DropIndex("dbo.MajorOfBusinesses", new[] { "StudentId" });
            DropIndex("dbo.MajorOfHumanities", new[] { "StudentId" });
            DropIndex("dbo.MajorOfSciences", new[] { "StudentId" });
            AddColumn("dbo.MajorOfBusinesses", "AdmissionTestId", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfBusinesses", "AdmissionTests_Id", c => c.Int());
            AddColumn("dbo.MajorOfHumanities", "AdmissionTestId", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfHumanities", "AdmissionTests_Id", c => c.Int());
            AddColumn("dbo.MajorOfSciences", "AdmissionTestId", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfSciences", "AdmissionTests_Id", c => c.Int());
            CreateIndex("dbo.MajorOfBusinesses", "AdmissionTests_Id");
            CreateIndex("dbo.MajorOfHumanities", "AdmissionTests_Id");
            CreateIndex("dbo.MajorOfSciences", "AdmissionTests_Id");
            AddForeignKey("dbo.MajorOfBusinesses", "AdmissionTests_Id", "dbo.AdmissionTests", "Id");
            AddForeignKey("dbo.MajorOfHumanities", "AdmissionTests_Id", "dbo.AdmissionTests", "Id");
            AddForeignKey("dbo.MajorOfSciences", "AdmissionTests_Id", "dbo.AdmissionTests", "Id");
            DropColumn("dbo.MajorOfBusinesses", "StudentId");
            DropColumn("dbo.MajorOfHumanities", "StudentId");
            DropColumn("dbo.MajorOfSciences", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MajorOfSciences", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfHumanities", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.MajorOfBusinesses", "StudentId", c => c.Int(nullable: false));
            DropForeignKey("dbo.MajorOfSciences", "AdmissionTests_Id", "dbo.AdmissionTests");
            DropForeignKey("dbo.MajorOfHumanities", "AdmissionTests_Id", "dbo.AdmissionTests");
            DropForeignKey("dbo.MajorOfBusinesses", "AdmissionTests_Id", "dbo.AdmissionTests");
            DropIndex("dbo.MajorOfSciences", new[] { "AdmissionTests_Id" });
            DropIndex("dbo.MajorOfHumanities", new[] { "AdmissionTests_Id" });
            DropIndex("dbo.MajorOfBusinesses", new[] { "AdmissionTests_Id" });
            DropColumn("dbo.MajorOfSciences", "AdmissionTests_Id");
            DropColumn("dbo.MajorOfSciences", "AdmissionTestId");
            DropColumn("dbo.MajorOfHumanities", "AdmissionTests_Id");
            DropColumn("dbo.MajorOfHumanities", "AdmissionTestId");
            DropColumn("dbo.MajorOfBusinesses", "AdmissionTests_Id");
            DropColumn("dbo.MajorOfBusinesses", "AdmissionTestId");
            CreateIndex("dbo.MajorOfSciences", "StudentId");
            CreateIndex("dbo.MajorOfHumanities", "StudentId");
            CreateIndex("dbo.MajorOfBusinesses", "StudentId");
            AddForeignKey("dbo.MajorOfSciences", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MajorOfHumanities", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MajorOfBusinesses", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
