using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
    public class MajorOfHumanitiesManager
    {
        MajorOfHumanitiesRepository _majorOfHumanitiesRepository = new MajorOfHumanitiesRepository();
        public bool Add(MajorOfHumanities majorOfHumanities)
        {
            return _majorOfHumanitiesRepository.Add(majorOfHumanities);
        }

        public List<MajorOfHumanities> GetAll()
        {
            return _majorOfHumanitiesRepository.GetAll();
        }
    }
}
