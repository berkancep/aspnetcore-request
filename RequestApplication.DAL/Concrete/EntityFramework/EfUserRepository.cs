using Microsoft.EntityFrameworkCore;
using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Concrete.EntityFramework
{
    public class EfUserRepository : IUserRepository
    {
        private readonly RequestContext _context;

        public EfUserRepository(RequestContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Add(user);
            Save();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                _context.Remove(entity);
                Save();
            }
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users;
        }

        public User Filter(User user)
        {
            return _context.Users.Include(a => a.Roles).FirstOrDefault(a => a.Email == user.Email && a.Password == user.Password);

        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(a => a.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            var entity = GetById(user.Id);

            if (entity != null)
            {
                _context.Update(entity);
                Save();
            }
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(a => a.Email == email);
        }
    }
}
