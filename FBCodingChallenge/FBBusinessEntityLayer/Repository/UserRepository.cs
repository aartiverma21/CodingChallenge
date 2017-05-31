using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using  FBDAL.DataContext;
using FBDAL.Entity;

namespace FBMiddleTier.Repository
{
    public class UserRepository : IRepository<User>
    {
        DataContext _userContext;

        public UserRepository()
        {
            _userContext = new DataContext();

        }
        public IEnumerable<User> List
        {
            get
            {
                return _userContext.UserDetail.ToList();
            }

        }

        public void AddUser(User entity)
        {
            _userContext.UserDetail.Add(entity);
            _userContext.SaveChanges();
        }
    }
}
