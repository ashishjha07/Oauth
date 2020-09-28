using EmployeeManagement.Employees;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web.Http;

namespace ExamRoom_Test.Controllers
{
    public class ApplicationController : ApiController
    {
        [Authorize(Roles = "Manager, Architect, Engineer")]
        [HttpGet]
        [Route("api/application/resource/{id}")]
        public List<EmployeeWrapper> Get(int id)
        {
            List<EmployeeWrapper> employeeWrappers = new List<EmployeeWrapper>();
            var identity = (ClaimsIdentity)User.Identity;
            if (identity != null)
            {
                employeeWrappers = GetEmployeeList(id);
            }
            return employeeWrappers;
        }

        private List<EmployeeWrapper> GetEmployeeList(int id)
        {
            var empWrapper = EmployeeManagement.EmployeesManagement.GetEmployee(id);

            return EmployeeManagement.EmployeesManagement.GetEmployeeList(empWrapper.Id, empWrapper.Company, empWrapper.Role);
        }
    }
}
