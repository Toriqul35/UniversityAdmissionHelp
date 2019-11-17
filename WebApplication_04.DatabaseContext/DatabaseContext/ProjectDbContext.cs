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
        public ProjectDbContext()
        {
            Configuration.LazyLoadingEnabled = false; // Disable Lazy Loading
        }

        public DbSet<Student> Students { set; get; }
    }
}
