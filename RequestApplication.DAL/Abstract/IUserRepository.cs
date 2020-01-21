using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        User GetById(int id);
        User GetByEmail(string email);
        User Filter(User user);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }
}
