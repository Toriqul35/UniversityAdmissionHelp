using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
   public class MajorOfSceienceManager
    {
        MajorOfSceienceRepository _majorOfSceienceRepository = new MajorOfSceienceRepository();

        public bool Add(MajorOfScience majorOfScience)
        {
            return _majorOfSceienceRepository.Add(majorOfScience);
        }

        public List<MajorOfScience> GetAll()
        {
            return _majorOfSceienceRepository.GetAll();
        }

    }
}
