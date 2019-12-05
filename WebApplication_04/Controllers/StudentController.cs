using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using WebApplication_04.BLL.BLL;
using WebApplication_04.Model.Model;
using WebApplication_04.Models;
using WebApplication_04.DatabaseContext.DatabaseContext;

namespace WebApplication_04.Controllers
{
    public class StudentController : Controller
    {
       
        StudentManager _studentManager = new StudentManager();
        MajorOfSceienceManager _majorOfSceienceManager = new MajorOfSceienceManager();
        MajorOfBusinessManager _majorOfBusinessManager = new MajorOfBusinessManager();
        ProjectDbContext _dbContext = new ProjectDbContext();


        public ActionResult Index()
        {
            return View();
        }
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
                    message = "Successfully Registration ";
                }
                else
                {
                    message = " Not Registration";
                }
            }
            else
            {
                message = "Registration  Failed";
            }
            ViewBag.Message = message;
            studentViewModel.Students = _studentManager.ViewStudent();
            return RedirectToAction("Index", "Student");
        }
        public ActionResult Login()
        {
            if (Request.Cookies.Get("student") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Student");
            }


        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index", "Home");
        }

        public JsonResult IsStudentExist(string email)
        {
            bool isExists = false;
            var studemtList = _studentManager.GetAll().Where(c => c.Email == email);


            if (studemtList.Count() > 0)
            {
                isExists = true;
            }

            return Json(isExists, JsonRequestBehavior.AllowGet);
        }
        public ActionResult MailCompose()
        {
            return View();
        }


        [HttpGet]
        public ActionResult MajorOfSceience()
        {
            SceienceViewModel _sceienceViewModel = new SceienceViewModel();
            _sceienceViewModel.MajorOfSciences = _majorOfSceienceManager.GetAll();


            return View(_sceienceViewModel);
        }
        [HttpPost]
        public ActionResult MajorOfSceience(SceienceViewModel majorOfScience)
        {

            string message = "";

            if (ModelState.IsValid)
            {
                MajorOfScience science = Mapper.Map<MajorOfScience>(majorOfScience);

                if (_majorOfSceienceManager.Add(science))
                {
                    message = "Successfully Registration ";
                }
                else
                {
                    message = " Not Registration";
                }
            }
            else
            {
                message = "Registration  Failed";
            }
            ViewBag.Message = message;
            majorOfScience.MajorOfSciences = _majorOfSceienceManager.GetAll();
           // return RedirectToAction("Index", "Student");
            return View();
        }

        [HttpGet]
        public ActionResult MajorOfBusiness()
        {
            BusinessViewModel _businessViewModel = new BusinessViewModel();
            _businessViewModel.MajorOfBusinesses = _majorOfBusinessManager.GetAll();
           


            return View(_businessViewModel);
        }
        [HttpPost]
        public ActionResult MajorOfBusiness(BusinessViewModel businessViewModel)
        {

            string message = "";

            if (ModelState.IsValid)
            {
                MajorOfBusiness Business = Mapper.Map<MajorOfBusiness>(businessViewModel);
              

                if (_majorOfBusinessManager.Add(Business))
                {
                    message = "Successfully Registration ";
                }
                else
                {
                    message = " Not Registration";
                }
            }
            else
            {
                message = "Registration  Failed";
            }
            ViewBag.Message = message;
            businessViewModel.MajorOfBusinesses = _majorOfBusinessManager.GetAll();
            // return RedirectToAction("Index", "Student");
            return View();
        }
    }
}