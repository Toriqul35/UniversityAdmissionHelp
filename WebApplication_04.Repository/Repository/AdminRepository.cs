using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Security;
using WebApplication_04.DatabaseContext.DatabaseContext;
using WebApplication_04.Model.Model;
using System.Threading.Tasks;

namespace WebApplication_04.Repository.Repository
{
    public class AdminRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public int Login(Admin  admin)
        {
            var users = _dbContext.Admins.FirstOrDefault(c => c.Email == admin.Email);
            if (users != null)
            {
                if (string.Compare(Crypto.Hash(admin.Pin), users.Pin) == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }

  

        public bool PostAdmission(PostAdmission postAdmission)
        {

            _dbContext.PostAdmissions.Add(postAdmission);


            return _dbContext.SaveChanges() > 0;
        }
        public List<PostAdmission> ViewPost()
        {
            return _dbContext.PostAdmissions.ToList();
        }
    }
}
