using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamRoom_Test.Models
{
    public class EmployeeRepository : IDisposable
    {
        EmployeeContext context = new EmployeeContext();
        //This method is used to check and validate the user credentials
        public Employee ValidateUser(string username, string password)
        {
            return context.employees.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }

    }
}