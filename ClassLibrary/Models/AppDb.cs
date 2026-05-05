using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions options) :base(options) {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
