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
    public class StudentRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        

        public bool Add(Student student)
        {
            
            int i = _dbContext.Students.Where(c => c.Email == student.Email).Count();
            {
                if (i > 0)
                {
                    return false;
                }
               
                _dbContext.Students.Add(student);


                return _dbContext.SaveChanges() > 0;
            }
        }
        public List<Student>ViewStudent()
        {
            return _dbContext.Students.ToList();
        }
        public int Login(Student student)
        {
            var users = _dbContext.Students.FirstOrDefault(c => c.Email == student.Email);
            if (users != null)
            {
                if (string.Compare(Crypto.Hash(student.Password), users.Password) == 0 && users.IsEmailVerified == true)
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

        public List<Student> GetAll()
        {

            return _dbContext.Students.ToList();
        }

    }
}
