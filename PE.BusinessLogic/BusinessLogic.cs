using PE.BusinessLogic.DBModel;
using PE.BusinessLogic.Interfaces;
using PE.Domain.Entities.User;
using System.Collections.Generic;
using System.Linq;

namespace PE.BusinessLogic
{
    public class BusinessLogic
    {
        private readonly MyDbContext _dbcontext = new MyDbContext();
        public BusinessLogic(MyDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }
        public BusinessLogic() { }
        public ISession GetSessionBL()
        {
            return new SessionBL();
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
    }
}
