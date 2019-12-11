using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Threading.Tasks;

namespace WebApplication_04.Repository.Repository
{
    public  class MajorOfHumanitiesRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(MajorOfHumanities majorOfHumanities)
        {
            _dbContext.MajorOfHumanities.Add(majorOfHumanities);
            return _dbContext.SaveChanges() > 0;
        }

        public List<MajorOfHumanities> GetAll()
        {
            return _dbContext.MajorOfHumanities.ToList();
        }


    }
}
