using RequestApplication.BLL.Abstract;
using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.BLL.Concrete
{
    public class UserBLL : IUserBLL
    {
        private readonly IUserRepository _userRepository;

        public UserBLL(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public IQueryable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserFilter(User user)
        {
            return _userRepository.Filter(user);
        }


        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }


        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetByEmail(email);
        }
    }
}
