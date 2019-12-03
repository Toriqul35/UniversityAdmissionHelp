using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class MajorOfScience
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
        public int Physics1st { get; set; }
        public int Physics2nd { get; set; }
        public int Chemistry1st { get; set; }
        public int Chemistry2nd { get; set; }
        public int Baiology1st { get; set; }
        public int Baiology2nd { get; set; }
        public int HigherMath1st { get; set; }
        public int HigherMath2nd { get; set; }

        public int TotalHSC { get; set; }
        public int Total_HSC_SSC { get; set; }

    }
}
