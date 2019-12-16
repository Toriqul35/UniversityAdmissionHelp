using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Security;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_04.Security;
using AutoMapper;
using WebApplication_04.BLL.BLL;
using WebApplication_04.Model.Model;
using WebApplication_04.Models;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebApplication_04.Controllers
{
    public class StudentController : Controller
    {
        AdminManager _adminManager = new AdminManager();
        ContactManager _contactManager = new ContactManager();
        StudentManager _studentManager = new StudentManager();
        MajorOfSceienceManager _majorOfSceienceManager = new MajorOfSceienceManager();
        MajorOfBusinessManager _majorOfBusinessManager = new MajorOfBusinessManager();
        MajorOfHumanitiesManager _majorOfHumanitiesManager = new MajorOfHumanitiesManager();
        ProjectDbContext _dbContext = new ProjectDbContext();


        public ActionResult Index()
        {
            return View();
        }
        // GET: Unique Data Check
        [HttpPost]
        public ActionResult CheckExist(string email)
        {
            var validateName = _dbContext.Students.FirstOrDefault
                                (x => x.Email == email );
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
        public ActionResult ApplyAdmission()
        {
            StudentViewModel studentViewModel = new StudentViewModel();
            studentViewModel.Students = _studentManager.ViewStudent();

            return View(studentViewModel);
        }

        [HttpPost]
        public ActionResult ApplyAdmission(StudentViewModel studentViewModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                Student student = Mapper.Map<Student>(studentViewModel);

                if (_studentManager.Add(student))
                {
                    message = "Done Successfully  ";
                }
                else
                {
                    message = "The email or cell number is already Exist";
                }
            }
            else
            {
                message = "Successfully  Failed";
            }
            ViewBag.Message = message;
            studentViewModel.Students = _studentManager.ViewStudent();
            return View(studentViewModel);
        }

        // GET: ERP/Login // for admin	
     [HttpGet]
        public ActionResult Login()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                if (_dbContext.Students.Where(X => X.Email == login.Email && X.Password == login.Password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Email or Password is not Match");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Email"] = login.Email;
                    return RedirectToAction("Index", "Student");
                }
            }
            {
                return RedirectToAction("Index", "Home");
            }

            //var user = _dbContext.Students.Where(X => X.Email == login.Email && X.Password == login.Password).Count();
            //if (user > 0)
            //{
            //    return RedirectToAction("Index", "Student");
            //}
            //else
            //{

            //    return RedirectToAction("Index", "Home");
            //}


        }


        [HttpGet]
        public ActionResult UpdateProfile(string Email)
        {

            var student = _studentManager.GetById(Email);

            StudentViewModel studentViewModel = Mapper.Map<StudentViewModel>(student);

            studentViewModel.Students = _studentManager.GetAll();

            return View(studentViewModel);
        }
        [HttpPost]
        public ActionResult UpdateProfile(StudentViewModel studentViewModel)
        {
            string message = "";


            if (ModelState.IsValid)
            {
                Student student = Mapper.Map<Student>(studentViewModel);

                if (_studentManager.Update(student))
                {
                    message = "Updated";
                }
                else
                {
                    message = "Not Updated";
                }
            }
            else
            {
                message = "ModelState Failed";
            }

            ViewBag.Message = message;
            studentViewModel.Students = _studentManager.GetAll();

            return View(studentViewModel);
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

        [HttpGet]
        public ActionResult MajorOfHuminties()
        {

            HumantiesViewModel _humantiesViewModel = new HumantiesViewModel();
            _humantiesViewModel.MajorOfHumanities = _majorOfHumanitiesManager.GetAll();
           
            return View(_humantiesViewModel);
        }
        [HttpPost]
        public ActionResult MajorOfHuminties(HumantiesViewModel humantiesViewModel)
        {

            string message = "";

            if (ModelState.IsValid)
            {
               MajorOfHumanities Humanties = Mapper.Map<MajorOfHumanities>(humantiesViewModel);


                if (_majorOfHumanitiesManager.Add(Humanties))
                {
                    message = "Successfully Application ";
                }
                else
                {
                    message = " Not Application";
                }
            }
            else
            {
                message = "Application  Failed";
            }
            ViewBag.Message = message;
            humantiesViewModel.MajorOfHumanities = _majorOfHumanitiesManager.GetAll();
            // return RedirectToAction("Index", "Student");
            return View();
        }

        public ActionResult ViewProfile()
        { 
            ModelState.Clear();
            return View(_studentManager.GetAll());
        }
        [HttpGet]
        public ActionResult SearchProfile(string searching)
        {
            var Post = from s in _dbContext.Students
                       select s;
            if (!String.IsNullOrEmpty(searching))
            {
                Post = Post.Where(s => s.City.Contains(searching) || s.City.Contains(searching) || s.Zipcode.Contains(searching) || s.Year.Contains(searching) || s.Gender.Contains(searching));
            }

            return View(Post.ToList());
        }

        public ActionResult Map()
        {

            return View();
        }

        public JsonResult IsMailExist(string email)
        {
            bool isExists = false;
            var emailtList = _studentManager.GetAll().Where(c => c.Email == email);


            if (emailtList.Count() > 0)
            {
                isExists = true;
            }

            return Json(isExists, JsonRequestBehavior.AllowGet);
        }

       

    }
}