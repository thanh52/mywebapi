using Base.Data.IRepositories;
using Base.Data.Models;
using Base.Data.UnitOfWork;
using Base.Helper;
using Base.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public UserService(IUnitOfWork uow, IUserRepository userRepository)
        {
            _unitOfWork = uow;
            _userRepository = userRepository;
        }

        public User GetUserByLogin(string userName, string password)
        {
            var user = _userRepository.GetUserByUserName(userName);
            if(user == null)
            {
                return null;
            }
            else
            {
                if (user.PasswordHash == PasswordHelper.HashPassword(password, Encoding.ASCII.GetBytes(user.Salt)))
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
        }
        public List<User> GetAllUser()
        {
            return _userRepository.GetAll().ToList();
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.Find(id);
        }
    }
}
