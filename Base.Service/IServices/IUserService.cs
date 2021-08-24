using Base.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Service.IServices
{
    public interface IUserService
    {
        User GetUserByLogin(string userName, string password);
        List<User> GetAllUser();
        User GetUserById(Guid id);

    }
}
