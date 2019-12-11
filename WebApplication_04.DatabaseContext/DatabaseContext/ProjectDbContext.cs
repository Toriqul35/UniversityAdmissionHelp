using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using WebApplication_04.Model.Model;

namespace WebApplication_04.DatabaseContext.DatabaseContext
{
   public class ProjectDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
        public DbSet<Admin> Admins { set; get; }
        public DbSet<AdmissionTests> AdmissionTests{ set; get; }
        public DbSet<PostAdmission> PostAdmissions{ set; get; }
        public DbSet<LiveChat> LiveChats{ set; get; }
        public DbSet<MajorOfScience> MajorOfSciences{ set; get; }
        public DbSet<MajorOfBusiness> MajorOfBusinesses{ set; get; }
        public DbSet<MajorOfHumanities> MajorOfHumanities{ set; get; }
        public DbSet<Contact> Contacts{ set; get; }
    }
}
