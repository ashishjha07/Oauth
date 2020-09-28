using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamRoom_Test.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name = EmployeeContext")
        { }
        public DbSet<Employee> employees { get; set; }
    }
}