using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Threading.Tasks;

namespace WebApplication_04.Repository.Repository
{
   public class MajorOfSceienceRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(MajorOfScience majorOfScience)
        {
            _dbContext.MajorOfSciences.Add(majorOfScience);
            return _dbContext.SaveChanges() > 0;
        }

        public List<MajorOfScience> GetAll()
        {
            return _dbContext.MajorOfSciences.ToList();
        }
    }
}
