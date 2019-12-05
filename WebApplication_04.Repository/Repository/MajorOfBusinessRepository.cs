using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Threading.Tasks;

namespace WebApplication_04.Repository.Repository
{
   public  class MajorOfBusinessRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(MajorOfBusiness majorOfBusiness)
        {
            _dbContext.MajorOfBusinesses.Add(majorOfBusiness);
            return _dbContext.SaveChanges() > 0;
        }

        public List<MajorOfBusiness> GetAll()
        {
            return _dbContext.MajorOfBusinesses.ToList();
        }

    }
}
