using EmployeeManagement.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public interface IEmployeeManagement
    {
        List<EmployeeWrapper> GetEmployeeList(int id, string company, string role);
        EmployeeWrapper GetEmployee(int id);
    }
}
