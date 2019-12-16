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
      
        public List<PostAdmission> GetAll()
        {
            return _dbContext.PostAdmissions.ToList();
        }
        public List<MajorOfBusiness> ViewBuisness()
        {
            return _dbContext.MajorOfBusinesses.ToList();
        }
        public bool DeleteBusiness(int id)
        {
            MajorOfBusiness acustomer = _dbContext.MajorOfBusinesses.FirstOrDefault((c => c.Id == id));
            _dbContext.MajorOfBusinesses.Remove(acustomer);
            return _dbContext.SaveChanges() > 0;
        }
        public List<MajorOfHumanities> ViewHumanities()
        {
            return _dbContext.MajorOfHumanities.ToList();
        }
        public bool DeleteHumanites(int id)
        {
            MajorOfHumanities acustomer = _dbContext.MajorOfHumanities.FirstOrDefault((c => c.Id == id));
            _dbContext.MajorOfHumanities.Remove(acustomer);
            return _dbContext.SaveChanges() > 0;
        }
        public List<MajorOfScience> ViewSceience()
        {
            return _dbContext.MajorOfSciences.ToList();
        }
        public bool DeleteSceience(int id)
        {
            MajorOfScience acustomer = _dbContext.MajorOfSciences.FirstOrDefault((c => c.Id == id));
            _dbContext.MajorOfSciences.Remove(acustomer);
            return _dbContext.SaveChanges() > 0;
        }

        public bool DeletePost(int id)
        {
            PostAdmission acustomer = _dbContext.PostAdmissions.FirstOrDefault((c => c.Id == id));
            _dbContext.PostAdmissions.Remove(acustomer);
            return _dbContext.SaveChanges() > 0;
        }

        public bool UpdatePost(PostAdmission postAdmission)
        {
            PostAdmission post = _dbContext.PostAdmissions.FirstOrDefault(c => c.Id == postAdmission.Id);
            if (post != null)
            {
                post.PostType = postAdmission.PostType;
                post.UniversityName = postAdmission.UniversityName;
                post.PostDate = postAdmission.PostDate;
                post.StartTest = postAdmission.StartTest;
                post.EndTest = postAdmission.EndTest;
                post.TotalSeat = postAdmission.TotalSeat;
                post.FilePath = postAdmission.FilePath;
            }
            return _dbContext.SaveChanges() > 0;
        }
        public PostAdmission GetByIdPost(int id)
        {

            return _dbContext.PostAdmissions.FirstOrDefault((c => c.Id == id));
        }

    }
}
