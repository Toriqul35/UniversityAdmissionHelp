using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class PostAdmission
    {
        public int Id { get; set; }
        public string PostType { get; set; }
        public string UniversityName { get; set; }
        public DateTime? PostDate { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public DateTime? StartTest { get; set; }
        public DateTime? EndTest { get; set; }
        public int TotalSeat{get;set;}
        public string FilePath { get; set; }

        public List<PostAdmission> PostAdmissions { get; set; }
    }
}
