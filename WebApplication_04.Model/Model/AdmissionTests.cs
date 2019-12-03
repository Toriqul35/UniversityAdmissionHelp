using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class AdmissionTests
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public String TypeOfMajor { get; set; }

        public string Choice1st{get;set;}
        public string Choice2nd{get;set;}
        public string Choice3rd{get;set;}
  

    }
}
