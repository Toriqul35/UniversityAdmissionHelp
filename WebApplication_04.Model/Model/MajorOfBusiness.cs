using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class MajorOfBusiness
    {
        public int Id { get; set; }
        public int AdmissionTestId { get; set; }
        public AdmissionTests AdmissionTests { get; set; }
        public int TotalSSC { get; set; }
        public int Bangla1st { get; set; }
        public int Bangla2nd { get; set; }
        public int Engish1st { get; set; }
        public int English2nd { get; set; }
        public int Ict { get; set; }
        public int Accounting1st { get; set; }
        public int Accounting2nd { get; set; }
        public int Finaance1st { get; set; }
        public int Finaance2nd { get; set; }
        public int Managment1st { get; set; }
        public int Managment2nd { get; set; }
        public int Economics1st { get; set; }
        public int Economics2nd { get; set; }

        public int TotalHSC { get; set; }
        public int Total_HSC_SSC { get; set; }

    }
}
