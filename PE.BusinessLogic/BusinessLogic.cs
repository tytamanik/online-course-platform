using PE.BusinessLogic;
using PE.BusinessLogic.DBModel;
using PE.BusinessLogic.Interfaces;
using PE.Domain.Entities.Course;
using PE.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PE.BusinessLogic
{
    public class BusinessLogic
    {
        private readonly MyDbContext _dbcontext;
        public Session Session { get;  set; }
        public BusinessLogic()
        {
            _dbcontext = new MyDbContext();
            Session = new Session();
        }
        public void AddUser(userDbTable user)
        {
            _dbcontext.Users.Add(user);
            _dbcontext.SaveChanges();
        }
        public userDbTable GetUserByUsermane(string username)
        {
            return _dbcontext.Users.SingleOrDefault(u => u.Username == username);
        }
        public List<userDbTable> GetUsers()
        {
            return _dbcontext.Users.ToList();
        }
        public void AddCourse(courseDbTable course)
        {
            _dbcontext.Courses.Add(course);
            _dbcontext.SaveChanges();
        }
        public List<courseDbTable> GetCourses()
        {
            return _dbcontext.Courses.ToList();
        }
        public userDbTable GetUserById(int? id)
        {
            return _dbcontext.Users.Find(id);
        }
        public courseDbTable GetCourseById(int id)
        {
            return _dbcontext.Courses.Find(id);
        }

	public List<courseDbTable> GetPurchasedCoursesByUserId(int id)
        {
            var userCourseIds = _dbcontext.UserCourses.Where(u => u.User == id).Select(u => u.Course).ToList();
            var purchasedCourses = _dbcontext.Courses.Where(c => userCourseIds.Contains(c.Id)).ToList();

            return purchasedCourses;
        }
	public void AddCourseToUser(int userId, courseDbTable course)
        {
            _dbcontext.Courses.Add(course);
            _dbcontext.SaveChanges();
            var usercourse = new userDbTableCourseDbTable { Course = course.Id, User = userId };
            _dbcontext.UserCourses.Add(usercourse);
            _dbcontext.SaveChanges();
        }
    }
}

public class Session
{
    public int? GetCurrentSession(HttpCookie cookie)
    {
        if (cookie != null)
        {
            if (int.TryParse(cookie.Value, out int Id))
            {
                var user = (new BusinessLogic()).GetUserById(Id);
                return user.Id;
            }
        }
        return null;
    }
    public HttpCookie SetCurrentSession(userDbTable user)
    {
        HttpCookie cookie = new HttpCookie("X-Jay");
        cookie.Value = user.Id.ToString();
        cookie.Expires = DateTime.Now.AddDays(1); // Set the expiration date
        return cookie;
    }
}
