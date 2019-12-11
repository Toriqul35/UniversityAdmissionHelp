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
            PostViewModel _postViewModel = new PostViewModel();
            _postViewModel.PostAdmissions = _adminManager.ViewPost();
            return View();
        }

        [HttpPost]
        public ActionResult PostAdmission(PostViewModel postViewModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
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
            postViewModel.PostAdmissions = _adminManager.ViewPost();
            return View(postViewModel);
        }
    }
}