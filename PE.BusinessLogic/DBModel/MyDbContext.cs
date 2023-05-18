using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PE.Domain.Entities.User;

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
    }
}
