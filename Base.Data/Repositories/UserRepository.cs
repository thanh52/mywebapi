using Base.Data.IRepositories;
using Base.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(HTIDbContext context) : base(context)
        {

        }
        public User GetUserByUserName(string userName)
        {
            return GetAll().FirstOrDefault(x => x.UserName == userName);
        }
    }
}
