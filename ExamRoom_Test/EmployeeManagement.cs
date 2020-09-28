using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamRoom_Test
{
    public static class EmployeeManagement
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly IEmployeeManagement EmployeesManagement = new EmployeesManagement();
    }
}