using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementRepo.Employees;

namespace EmployeeManagementRepo.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name = EmployeeContext")
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}
