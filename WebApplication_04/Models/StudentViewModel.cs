using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_04.Model.Model;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication_04.Models
{
    public class StudentViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Is Not Valid Email")]
        [Remote("CheckExist", "Student", ErrorMessage = "The Email is exists")]
        public string Email { get; set; }

        [Display(Name = "Email")]
       
        [MaxLength(11, ErrorMessage = "Is not right cell number")]
        [MinLength(11, ErrorMessage = "Is not right cell number")]
        public string Contact { get; set; }


        public List<Student> Students { get; set; }
    }
}