using EmployeeManagementRepo.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementRepo
{
    public interface IEmployeeManagementRepo
    {
        List<Employee> GetEmployees(int id, string company, string role);
        Employee GetEmployee(int id);
    }
}
