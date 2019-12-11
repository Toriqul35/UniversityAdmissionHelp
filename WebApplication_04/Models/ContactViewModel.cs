using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_04.Model.Model;

namespace WebApplication_04.Models
{
    public class ContactViewModel
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Typeofmajor { get; set; }
        public string TypeOfMajor { get; set; }
        public string Massage { get; set; }

        public List<Contact> Contacts { get; set; }


    }
}