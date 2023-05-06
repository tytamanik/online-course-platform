using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PE.Domain.Entities.User;

namespace PE.BusinessLogic.DBModel
{
    public class MyDbContextInitializer : DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            var users = new userDbTable
            { Username = "Example", Email = "Example", Id = 1, Password = "Example" };
            context.Users.Add(users);
            context.SaveChanges();
        }
    }
}
