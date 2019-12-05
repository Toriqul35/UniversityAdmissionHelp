using System;
using System.Collections.Generic;
using WebApplication_04.Model.Model;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_04.Models
{
    public class BusinessViewModel
    {
        public int Id { get; set; }
        public int AdmissionTestId { get; set; }
        public AdmissionTests AdmissionTests { get; set; }

      
        public int TotalSSC { get; set; }
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Can not be Empty")]
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
        public int Marketing1st { get; set; }
        public int Marketing2nd { get; set; }

        public int TotalHSC { get; set; }
        public int Total_HSC_SSC { get; set; }

        public List<MajorOfBusiness> MajorOfBusinesses { get; set; }

    }
}