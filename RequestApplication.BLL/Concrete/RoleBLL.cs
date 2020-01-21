using RequestApplication.BLL.Abstract;
using RequestApplication.DAL.Abstract;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.BLL.Concrete
{
    public class RoleBLL : IRoleBLL
    {
        private readonly IRoleRepository _roleRepository;

        public RoleBLL(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public void AddRole(Role role)
        {
            _roleRepository.Add(role);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.Delete(id);
        }

        public IQueryable<Role> GetAllRoles()
        {
            return _roleRepository.GetAll();
        }

        public Role GetRole(int id)
        {
            return _roleRepository.Get(id);
        }

        public void UpdateRole(Role role)
        {
            _roleRepository.Update(role);
        }
    }
}
