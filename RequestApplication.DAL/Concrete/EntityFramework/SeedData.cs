using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RequestApplication.DAL.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            RequestContext _context = app.ApplicationServices.GetRequiredService<RequestContext>();

            if (!_context.Roles.Any())
            {
                var roles = new List<Role>
                {
                    new Role() { Name = "User" },
                    new Role() { Name = "Admin" }
                };

                _context.Roles.AddRange(roles);

                _context.SaveChanges();

                _context.Users.AddRange(
                    new User() { Email = "berkancep@gmail.com", Password = "b123456b", FullName = "Berkan Çep", Phone = "5372710868", RoleId = roles[1].Id }
                    );

                _context.SaveChanges();

            }

 

        }
    }
}
