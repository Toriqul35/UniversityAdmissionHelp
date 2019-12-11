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

            int i = _dbContext.Students.Where(c => c.Email == student.Email || c.Contact == student.Contact).Count();
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
                if (string.Compare(Crypto.Hash(student.Password), users.Password) == 0)
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
        public bool Update(Student student)
        {
            Student aStudent = _dbContext.Students.FirstOrDefault(c => c.Email == student.Email);
            if (aStudent != null)
            {
            
                aStudent.FullName = student.FullName;
                aStudent.FatherName = student.FatherName;
                aStudent.MotherName = student.MotherName;
                aStudent.Contact = student.Contact;
                aStudent.Address1 = student.Address1;
                aStudent.Address2 = student.Address2;
                aStudent.City = student.City;
                aStudent.State = student.State;
                aStudent.Country = student.Country;
                aStudent.Zipcode = student.Zipcode;

            }

            return _dbContext.SaveChanges() > 0;
        }

        public List<Student> GetAll()
        {

            return _dbContext.Students.ToList();
        }
        public Student GetById(string Email)
        {

            return _dbContext.Students.FirstOrDefault((c => c.Email == Email));
        }

        public bool Delete(int id)
        {
            Student aStudent = _dbContext.Students.FirstOrDefault((c => c.Id == id));
            _dbContext.Students.Remove(aStudent);
            return _dbContext.SaveChanges() > 0;
        }

       
       
    }
}
