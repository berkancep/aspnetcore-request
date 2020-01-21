using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Concrete.EntityFramework
{
    public class EfRoleRepository : IRoleRepository
    {
        private readonly RequestContext _context;

        public EfRoleRepository(RequestContext context)
        {
            _context = context;
        }
        public void Add(Role role)
        {
            _context.Add(role);
            Save();
        }

        public void Delete(int id)
        {
            var entity = Get(id);

            if (entity != null)
            {
                _context.Remove(entity);
                Save();
            }
        }

        public Role Get(int id)
        {
            return _context.Roles.FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<Role> GetAll()
        {
            return _context.Roles;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Role role)
        {
            var entity = Get(role.Id);

            if (entity != null)
            {
                _context.Update(entity);
                Save();
            }
        }
    }
}
