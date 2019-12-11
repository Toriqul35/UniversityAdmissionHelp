namespace WebApplication_04.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Pin = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdmissionTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfMajor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Typeofmajor = c.String(),
                        Massage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LiveChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        UserName = c.String(),
                        Email = c.String(),
                        Massage = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        Gender = c.String(),
                        Day = c.String(),
                        Month = c.String(),
                        Year = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        Zipcode = c.String(),
                        Country = c.String(),
                        Password = c.String(),
                        TypeOfMajor = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MajorOfBusinesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        Date = c.DateTime(),
                        TotalSSC = c.Int(nullable: false),
                        Bangla1st = c.Int(nullable: false),
                        Bangla2nd = c.Int(nullable: false),
                        Engish1st = c.Int(nullable: false),
                        English2nd = c.Int(nullable: false),
                        Ict = c.Int(nullable: false),
                        Accounting1st = c.Int(nullable: false),
                        Accounting2nd = c.Int(nullable: false),
                        Finaance1st = c.Int(nullable: false),
                        Finaance2nd = c.Int(nullable: false),
                        Managment1st = c.Int(nullable: false),
                        Managment2nd = c.Int(nullable: false),
                        Marketing1st = c.Int(nullable: false),
                        Marketing2nd = c.Int(nullable: false),
                        TotalHSC = c.Int(nullable: false),
                        Total_HSC_SSC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.MajorOfHumanities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        TotalSSC = c.Int(nullable: false),
                        Bangla1st = c.Int(nullable: false),
                        Bangla2nd = c.Int(nullable: false),
                        Engish1st = c.Int(nullable: false),
                        English2nd = c.Int(nullable: false),
                        Ict = c.Int(nullable: false),
                        Economics1st = c.Int(nullable: false),
                        Economics2nd = c.Int(nullable: false),
                        Sociology1st = c.Int(nullable: false),
                        Sociology2nd = c.Int(nullable: false),
                        Geography1st = c.Int(nullable: false),
                        Geography2nd = c.Int(nullable: false),
                        IslamicHistory1st = c.Int(nullable: false),
                        IslamicHistory2nd = c.Int(nullable: false),
                        TotalHSC = c.Int(nullable: false),
                        Total_HSC_SSC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.MajorOfSciences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        TotalSSC = c.Int(nullable: false),
                        Bangla1st = c.Int(nullable: false),
                        Bangla2nd = c.Int(nullable: false),
                        Engish1st = c.Int(nullable: false),
                        English2nd = c.Int(nullable: false),
                        Ict = c.Int(nullable: false),
                        Physics1st = c.Int(nullable: false),
                        Physics2nd = c.Int(nullable: false),
                        Chemistry1st = c.Int(nullable: false),
                        Chemistry2nd = c.Int(nullable: false),
                        Baiology1st = c.Int(nullable: false),
                        Baiology2nd = c.Int(nullable: false),
                        HigherMath1st = c.Int(nullable: false),
                        HigherMath2nd = c.Int(nullable: false),
                        TotalHSC = c.Int(nullable: false),
                        Total_HSC_SSC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.PostAdmissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        PostType = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        Title = c.String(),
                        FileName = c.String(),
                        FilePath = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostAdmissions", "AdminId", "dbo.Admins");
            DropForeignKey("dbo.MajorOfSciences", "StudentId", "dbo.Students");
            DropForeignKey("dbo.MajorOfHumanities", "StudentId", "dbo.Students");
            DropForeignKey("dbo.MajorOfBusinesses", "StudentId", "dbo.Students");
            DropForeignKey("dbo.LiveChats", "StudentId", "dbo.Students");
            DropIndex("dbo.PostAdmissions", new[] { "AdminId" });
            DropIndex("dbo.MajorOfSciences", new[] { "StudentId" });
            DropIndex("dbo.MajorOfHumanities", new[] { "StudentId" });
            DropIndex("dbo.MajorOfBusinesses", new[] { "StudentId" });
            DropIndex("dbo.LiveChats", new[] { "StudentId" });
            DropTable("dbo.PostAdmissions");
            DropTable("dbo.MajorOfSciences");
            DropTable("dbo.MajorOfHumanities");
            DropTable("dbo.MajorOfBusinesses");
            DropTable("dbo.Students");
            DropTable("dbo.LiveChats");
            DropTable("dbo.Contacts");
            DropTable("dbo.AdmissionTests");
            DropTable("dbo.Admins");
        }
    }
}
