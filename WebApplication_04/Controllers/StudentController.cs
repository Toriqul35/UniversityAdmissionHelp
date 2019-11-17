using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApplication_04.BLL.BLL;
using WebApplication_04.Model.Model;
using WebApplication_04.Models;
using System.Web.Mvc;
using WebApplication_04.DatabaseContext.DatabaseContext;

namespace WebApplication_04.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager = new StudentManager();

        ProjectDbContext _dbContext = new ProjectDbContext();

        // GET: Unique Data Check
        public ActionResult CheckExist(string email, int? Id)
        {
            var validateName = _dbContext.Students.FirstOrDefault
                                (x => x.Email == email && x.Id != Id);
            if (validateName != null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Student
        [HttpGet]
        public ActionResult Add()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Students = _studentManager.ViewStudent();


            return View(studentViewModel);
        }

        [HttpPost]
        public ActionResult Add(StudentViewModel studentViewModel)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                Student student = Mapper.Map<Student>(studentViewModel);

                if (_studentManager.Add(student))
                {
                    message = "Saved";
                }
                else
                {
                    message = "Not Saved";
                }
            }
            else
            {
                message = "Create Failed";
            }

            ViewBag.Message = message;
            studentViewModel.Students = _studentManager.ViewStudent();
            return View(studentViewModel);
        }
    }
}