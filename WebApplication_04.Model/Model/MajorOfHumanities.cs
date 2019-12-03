using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class MajorOfHumanities
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
        public int Economics1st { get; set; }
        public int Economics2nd { get; set; }
        public int Sociology1st { get; set; }
        public int Sociology2nd { get; set; }
        public int Geography1st { get; set; }
        public int Geography2nd { get; set; }
        public int IslamicHistory1st { get; set; }
        public int IslamicHistory2nd { get; set; }

        public int TotalHSC { get; set; }
        public int Total_HSC_SSC { get; set; }

    }
}
