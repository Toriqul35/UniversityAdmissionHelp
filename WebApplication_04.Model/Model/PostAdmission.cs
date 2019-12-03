using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
   public class PostAdmission
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public string PostType { get; set; }
        public DateTime PostDate{ get; set; }      
        public string Title { get; set; }    
        public string FileName { get; set; }     
        public string FilePath { get; set; }

    }
}
