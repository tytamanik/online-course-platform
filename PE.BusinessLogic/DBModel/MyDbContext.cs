using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using PE.Domain.Entities.User;

namespace PE.BusinessLogic.DBModel
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
