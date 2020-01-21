using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Abstract
{
    public interface IRoleRepository
    {
        IQueryable<Role> GetAll();
        Role Get(int id);
        void Add(Role role);
        void Update(Role role);
        void Delete(int id);
        void Save();
    }
}
