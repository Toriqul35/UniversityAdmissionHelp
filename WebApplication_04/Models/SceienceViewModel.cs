using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_04.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_04.Models
{
    public class SceienceViewModel
    {
        public int Id { get; set; }
        public int AdmissionTestId { get; set; }
        public AdmissionTests AdmissionTests { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Total SSC Marks")]
       
        public int? TotalSSC { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Bangla 1st Paper")]
        [Range(60,99)]
        public int? Bangla1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Bangla 2nd Paper")]
        public int? Bangla2nd { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "English 1st Paper")]
        public int? Engish1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "English 2nd Paper")]
        public int? English2nd { get; set; }


        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "ICT")]
        public int? Ict { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Physics 1st Paper")]
        public int? Physics1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Physics 2nd Paper")]
        public int? Physics2nd { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Chemistry 1st Paper")]
        public int? Chemistry1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Chemistry 2nd Paper")]
        public int? Chemistry2nd { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Baiology 1st Paper")]
        public int? Baiology1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Baiology 2nd Paper")]
        public int? Baiology2nd { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "HigherMath 1st Paper")]
        public int? HigherMath1st { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "HigherMath 2nd Paper")]
        public int? HigherMath2nd { get; set; }


        [Display(Name = "TotalHSC Number")]
        public int? TotalHSC { get; set; }

        [Display(Name = "Total Number")]
        public int? Total_HSC_SSC { get; set; }

        public List<MajorOfScience> MajorOfSciences{ get; set; }

    }
}