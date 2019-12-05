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
        [Required(ErrorMessage = "Please input Name ")]
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EducationType { get; set; }
        public string State { get; set; }
        public string EducationDescription { get; set; }
        public string Password { get; set; }


        public List<Student> Students { get; set; }
    }
}