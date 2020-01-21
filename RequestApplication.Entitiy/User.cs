using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.Entitiy
{
    public class User
    {
        // Sistem bir kullanıcının bir rolü olabilecek şekilde tasarlandı.


        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public Role Roles { get; set; }

        public ICollection<Request> Requests { get; set; }

    }
}
