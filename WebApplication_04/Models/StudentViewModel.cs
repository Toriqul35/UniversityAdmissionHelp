using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
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
        //[Remote("CheckExist", "Student", ErrorMessage = "The Email is exists")]
        public string Email { get; set; }

        [Display(Name = "Email")]
       
        [MaxLength(11, ErrorMessage = "Is not right cell number")]
        [MinLength(11, ErrorMessage = "Is not right cell number")]
        public string Contact { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Password Required")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Minimum 4 characters number")]
        public string Password { get; set; }

        //[Display(Name = "Confrim Pasword")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Do not match the password")]
        //public string ConfrimPassword { get; set; }


        public List<Student> Students { get; set; }
    }
}