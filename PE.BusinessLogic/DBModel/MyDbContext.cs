using PE.Domain.Entities.Course;
using PE.Domain.Entities.User;
using PE.Domain.Entities.categoryDbTable;
using PE.Domain.Entities;
using System.Data.Entity;


namespace PE.BusinessLogic.DBModel
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() :
            base("name=CoursePlat")
        {
        }
        public MyDbContext(string connectionString)
            : base(connectionString) { }
        public DbSet<userDbTable> Users { get; set; }
        public DbSet<courseDbTable> Courses { get; set; }
        public DbSet<categoryDbTable> Categories { get; set; }
        public DbSet<userDbTableCourseDbTable> UserCourses { get; set; }
    }
}
