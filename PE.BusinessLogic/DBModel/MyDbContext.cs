using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PE.Domain.Entities.User;
using PE.Domain.Entities.Course;


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
    }
}
