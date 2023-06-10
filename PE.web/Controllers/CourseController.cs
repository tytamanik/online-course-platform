using PE.Domain.Entities.Course;
using PE.Domain.Entities.User;
using PE.web.App_Start;
using PE.web.Models;
using System.Web.Mvc;

namespace PE.web.Controllers
{
    public class CourseController : BaseController
    {
        // GET: Course
        [AdminMode]
        public ActionResult Index()
        {
           var courses = _businessLogic.GetCourses();
            return View(courses);
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult CreationPage()
        { 
            return View();
        }
        public ActionResult CreateCourse(courseCreation model)
        {

            var course = new courseDbTable { Name = model.Name, Description = model.Description };
            _businessLogic.AddCourseToUser(1, course);
            return RedirectToAction("Temp", "Course");
        }
        public ActionResult Temp()
        {
            var courses = _businessLogic.GetPurchasedCoursesByUserId(1);
            return View(courses);
        }
    }
}
