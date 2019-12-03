using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class Student
    {
        public int Id { get; set; }
    
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ContactPerson { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string EducationType { get; set; }
        public string Image { get; set; }
        public string EducationDescription { get; set; }
        public string Password { get; set; }
        public string ConfrimPassword { get; set; }              
 


    }
}
