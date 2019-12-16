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

        public string FullName { get; set; }
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
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public string TypeOfMajor { get; set; }
        public string State { get; set; }
    }
}
