using Microsoft.EntityFrameworkCore;
using RequestApplication.Entitiy;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestApplication.DAL.Concrete.EntityFramework
{
    public class RequestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=RequestDB;user ID=sa;password=123");
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}
