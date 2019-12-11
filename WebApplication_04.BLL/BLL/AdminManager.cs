using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
     public class AdminManager
     {
        AdminRepository _admin = new AdminRepository();

        public int Login(Admin admin)
        {
            return _admin.Login(admin);
        }
        public bool PostAdmission(PostAdmission postAdmission)
        {
            return _admin.PostAdmission(postAdmission);
        }

        public List<PostAdmission> ViewPost()
        {
            return _admin.ViewPost();
        }
    }
}
