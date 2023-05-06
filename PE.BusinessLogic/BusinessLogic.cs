using PE.BusinessLogic.DBModel;
using PE.BusinessLogic.Interfaces;
using PE.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE.BusinessLogic
{ 

    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public void AddUser(userDbTable user)
        {
            using (var db = new MyDbContext()) 
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
