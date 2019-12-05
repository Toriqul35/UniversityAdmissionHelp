using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApplication_04.Model.Model;
using WebApplication_04.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication_04
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            //Initialize
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<StudentViewModel, Student>();
                cfg.CreateMap<Student, StudentViewModel>();

                cfg.CreateMap<SceienceViewModel, MajorOfScience>();
                cfg.CreateMap<MajorOfScience, SceienceViewModel>();

                cfg.CreateMap<BusinessViewModel, MajorOfBusiness>();
                cfg.CreateMap<MajorOfBusiness, BusinessViewModel>();



            });
        }
    }
}
