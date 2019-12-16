using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using WebApplication_04.BLL.BLL;
using WebApplication_04.Model.Model;
using System.Web.Security;
using WebApplication_04.Models;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Web.Mvc;
using AutoMapper;

namespace WebApplication_04.Controllers
{
    public class AdminController : Controller
    {
        StudentManager _studentManager = new StudentManager();
        ProjectDbContext _dbContext = new ProjectDbContext();
        AdminManager _adminManager = new AdminManager();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Celender()
        {
            return View();
        }
        public ActionResult Map()
        {
            return View();
        }

        public ActionResult Galary()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
           
                var admi =_dbContext.Admins.Where(X => X.Email == admin.Email && X.Pin == admin.Pin).Count();
                if (admi > 0)
                {
                    
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                   
                    return RedirectToAction("Index", "Home");
                }

           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Response.Cookies["admin"].Expires = DateTime.Now.AddDays(-1);
            return RedirectToAction("Index", "Home");


        }
        [HttpGet]
        public ActionResult PostAdmission()
        {
            //PostViewModel _postViewModel = new PostViewModel();
            //_postViewModel.PostAdmissions = _adminManager.ViewPost();
            return View();
        }

        [HttpPost]
        public ActionResult PostAdmission(PostViewModel postViewModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                //string fileName = Path.GetFileNameWithoutExtension(postViewModel.ImageFile.FileName);
                string fileName = Path.GetFileNameWithoutExtension(postViewModel.Files.FileName);
                postViewModel.FilePath =  fileName + System.IO.Path.GetExtension(postViewModel.Files.FileName);
                fileName = "~/Notice/" + fileName + System.IO.Path.GetExtension(postViewModel.Files.FileName);
                postViewModel.Files.SaveAs(Server.MapPath(fileName));

                PostAdmission post = Mapper.Map<PostAdmission>(postViewModel);

                if (_adminManager.PostAdmission(post))
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
            //postViewModel.PostAdmissions = _adminManager.ViewPost();
            return RedirectToAction("Index");
        }

        public ActionResult ViewAdmission( PostAdmission postAdmission)
        {
            ModelState.Clear();
            return View(_adminManager.GetAll());
        }
        public ActionResult ViewBuisness(MajorOfBusiness majorOfBusiness)
        {
            ModelState.Clear();
            return View(_adminManager.ViewBuisness());
        }
        public ActionResult ViewHumanites(MajorOfHumanities majorOfHumanities)
        {
            ModelState.Clear();
            return View(_adminManager.ViewHumanities());
        }
        public ActionResult ViewSceience(MajorOfScience majorOfScience)
        {
            ModelState.Clear();
            return View(_adminManager.ViewSceience());
        }

        [HttpGet]
        public FileResult DownloadFile(int id, PostAdmission obj)
        {
            obj = _dbContext.PostAdmissions.FirstOrDefault(c => c.Id == id);
            
            string filepath = Server.MapPath("~/Notice/" + obj.FilePath);

            return File(filepath, "application/pdf", obj.FilePath + ".pdf");
        }

        [HttpGet]
        public ActionResult SearchAdmission(string searching)
        {
            var Post = from s in _dbContext.PostAdmissions
                           select s;
            if (!String.IsNullOrEmpty(searching))
            {
                Post = Post.Where(s => s.UniversityName.Contains(searching) || s.PostType.Contains(searching));
            }

            return View(Post.ToList());
        }
        public ActionResult DeletePost(int id)
        {
            try
            {
                
                if (_adminManager.DeletePost(id))
                {
                    ViewBag.AlertMsg = "Post Deleted Successfully";
                }
                return RedirectToAction("ViewAdmission");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult DeleteBusiness(int id)
        {
            try
            {

                if (_adminManager.DeleteBusiness(id))
                {
                    ViewBag.AlertMsg = "Post Deleted Successfully";
                }
                return RedirectToAction("ViewBuisness");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult DeleteHumanities(int id)
        {
            try
            {

                if (_adminManager.DeleteHumanites(id))
                {
                    ViewBag.AlertMsg = "Post Deleted Successfully";
                }
                return RedirectToAction("ViewHumanites");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult DeleteSceience(int id)
        {
            try
            {

                if (_adminManager.DeleteSecience(id))
                {
                    ViewBag.AlertMsg = "Post Deleted Successfully";
                }
                return RedirectToAction("ViewSceience");
            }
            catch
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult UpdatePost(int id)
        {
            var post = _adminManager.GetByIdPost(id);
           PostViewModel postViewModel = Mapper.Map<PostViewModel>(post);
            postViewModel.PostAdmissions = _adminManager.GetAll();

            return RedirectToAction("AllCustomer");

        }
        [HttpPost]
        public ActionResult UpdatePost(PostViewModel postViewModel)
        {
            string message = "";

            if (ModelState.IsValid)
            {
               PostAdmission post = Mapper.Map<PostAdmission>(postViewModel);

                if (_adminManager.UpdatePost(post))
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
                message = "Update Failed";
            }

            ViewBag.Message = message;
            postViewModel.PostAdmissions = _adminManager.GetAll();
            return RedirectToAction("ViewAdmission");
        }

    }
}