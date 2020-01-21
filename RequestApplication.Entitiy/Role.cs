using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.Entitiy
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
