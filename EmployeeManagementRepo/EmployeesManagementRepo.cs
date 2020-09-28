using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementRepo;
using EmployeeManagementRepo.Employees;
using EmployeeManagementRepo.Repository;

namespace EmployeeManagementRepo
{
    public class EmployeesManagementRepo : IEmployeeManagementRepo
    {
        BaseRepository<Employee> EmployeesRepo;

        public EmployeesManagementRepo()
        {
            EmployeesRepo = new BaseRepository<Employee>();
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                return EmployeesRepo.GetByID(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured", ex.Message);
                return null;
            }
        }

        public List<Employee> GetEmployees(int id, string company, string role)
        {
            try
            {
                List<Employee> employeeReturn = new List<Employee>();
                Employee emp = GetEmployee(id);

                if(emp.Role == "Manager")
                {
                    employeeReturn = EmployeesRepo.Get().Where(x => x.Role == "Engineer" || x.Role == "Architect" && x.Company == company && x.Department == emp.Department).ToList();
                }

                else if(emp.Role == "Architect")
                {
                    employeeReturn = EmployeesRepo.Get().Where(x => x.Role == "Engineer" && x.Company == company && x.Department == emp.Department).ToList();
                }
                
                return employeeReturn;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured", ex.Message);
                return null;
            }
        }
    }
}
