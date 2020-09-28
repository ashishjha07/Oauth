using EmployeeManagementRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public static class EmployeeRepo
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IEmployeeManagementRepo EmployeeManagementRepo = new EmployeesManagementRepo();
    }
}
