using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


    }
}
