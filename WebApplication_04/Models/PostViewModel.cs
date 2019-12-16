using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_04.Model.Model;

namespace WebApplication_04.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Faculty")]
        public string PostType { get; set; }
        [Display(Name = "University")]
        public string UniversityName { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime? PostDate { get; set; }

        [Display(Name = "Start of apply date")]
        [DataType(DataType.Date)]
        public DateTime? StartTest { get; set; }
        [Display(Name = "End of apply date")]
        [DataType(DataType.Date)]
        public DateTime? EndTest { get; set; }
        [Display(Name = "Number Of Total Seats")]
        public int TotalSeat { get; set; }
        public string FilePath { get; set; }

        public HttpPostedFileBase Files { get; set; }

        public List<PostAdmission> PostAdmissions { get; set; }
    }
}