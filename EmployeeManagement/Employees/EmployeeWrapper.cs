using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Employees
{
    public class EmployeeWrapper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
    }
}
