using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.IO;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_04.Model.Model
{
    public class PostAdmission
    {
        public int Id { get; set; }

        [Display(Name = "Faculty")]
        public string PostType { get; set; }

        [Display(Name = "University")]
        public string UniversityName { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime? PostDate { get; set; }

        [Display(Name = "Start apply date")]
        public DateTime? StartTest { get; set; }

        [Display(Name = "End apply date")]
        public DateTime? EndTest { get; set; }

        [Display(Name = "Total Seats")]
        public int TotalSeat{get;set;}

        [Display(Name = "File Name")]
        public string FilePath { get; set; }

        
    }
}
