using Base.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUserName(string userName);
    }
}
