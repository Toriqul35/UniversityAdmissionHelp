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

        public List<PostAdmission> GetAll()
        {
            return _admin.GetAll();
        }
        public List<MajorOfBusiness> ViewBuisness()
        {
            return _admin.ViewBuisness();
        }
        public bool DeleteBusiness(int id)
        {
            return _admin.DeleteBusiness(id);
        }
        public List<MajorOfHumanities> ViewHumanities()
        {
            return _admin.ViewHumanities();
        }
        public bool DeleteHumanites(int id)
        {
            return _admin.DeleteHumanites(id);
        }
        public List<MajorOfScience> ViewSceience()
        {
            return _admin.ViewSceience();
        }
        public bool DeleteSecience(int id)
        {
            return _admin.DeleteSceience(id);
        }
        public bool DeletePost(int id)
        {
            return _admin.DeletePost(id);
        }

        public bool UpdatePost(PostAdmission postAdmission)
        {
            return _admin.UpdatePost(postAdmission);
        }

        public PostAdmission GetByIdPost(int id)
        {
            return _admin.GetByIdPost(id);
        }

    }
}
