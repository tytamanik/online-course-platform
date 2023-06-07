using PE.Domain.Entities.Course;
using PE.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PE.web.Controllers
{
    public class CourseController : Controller
    {
        private readonly BusinessLogic.BusinessLogic businessLogic;
        
        public CourseController()
        {
            businessLogic = new BusinessLogic.BusinessLogic();
        }
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CourseDetails()
        {
            return View();
        }
        public ActionResult CreateCourse(courseCreation model)
        {
            var course = new courseDbTable { Name = model.Name, Description = model.Description };
            businessLogic.AddCourse(course);
            return View();
        }
    }
}