using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
   public class MajorOfBusinessManager
    {
        MajorOfBusinessRepository _majorOfBusinessRepository = new MajorOfBusinessRepository();

        public bool Add(MajorOfBusiness majorOfBusiness)
        {
            return _majorOfBusinessRepository.Add(majorOfBusiness);
        }

        public List<MajorOfBusiness> GetAll()
        {
            return _majorOfBusinessRepository.GetAll();
        }
    }
}
