using EmployeeManagementRepo.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementRepo.Repository
{
    public class InitializeDB : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            context.Employees.Add(new Employees.Employee { Id = 1, Company = "ExamRoom.AI", Department = "Product", Name = "Ashish", Email = "Ashish@gmail.com", Password = "12345", Role = "Manager", UserName = "ashish.kumar" });
            context.Employees.Add(new Employees.Employee { Id = 1, Company = "ExamRoom.AI", Department = "Product", Name = "XYZ", Email = "XYZ@ExamRoom.com", Password = "12345", Role = "Engineer", UserName = "XYZ.ABC" });
            context.Employees.Add(new Employees.Employee { Id = 1, Company = "ExamRoom.AI", Department = "Product", Name = "ABC", Email = "ABC@ExamRoom.com", Password = "12345", Role = "Architect", UserName = "ABC.XYZ" });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
