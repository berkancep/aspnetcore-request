using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.BLL.Abstract
{
    public interface IUserBLL
    {
        IQueryable<User> GetAllUsers();
        User GetUserById(int id);
        User GetUserByEmail(string email);
        User GetUserFilter(User user);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
