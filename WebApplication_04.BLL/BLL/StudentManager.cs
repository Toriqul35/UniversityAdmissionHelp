using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public List<Student>ViewStudent()
        {
            return _studentRepository.ViewStudent();
        }

        public int Login(Student student)
        {
            return _studentRepository.Login(student);
        }
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
    }
}
