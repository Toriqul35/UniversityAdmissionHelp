using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_04.Model.Model
{
    public class LiveChat
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string UserName { get; set; }
        public string  Email { get; set; }
        public string Massage { get; set; }

    }
}
