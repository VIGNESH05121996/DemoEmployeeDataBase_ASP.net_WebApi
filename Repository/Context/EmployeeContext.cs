using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
