using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeManagement.Employees;
using EmployeeManagementRepo.Employees;

namespace EmployeeManagement
{
    public class EmployeesManagement : IEmployeeManagement
    {
        public EmployeesManagement()
        {
        }

        public EmployeeWrapper GetEmployee(int id)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Employee, EmployeeWrapper>()
                );
            var mapper = new Mapper(config);
            var emp = EmployeeRepo.EmployeeManagementRepo.GetEmployee(id);
            return mapper.Map<EmployeeWrapper>(emp);
        }

        public List<EmployeeWrapper> GetEmployeeList(int id, string company, string role)
        {
            List<EmployeeWrapper> employeeWrappersList = new List<EmployeeWrapper>();
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Employee, EmployeeWrapper>()
                );
            var empList = EmployeeRepo.EmployeeManagementRepo.GetEmployees(id, company, role);
            var mapper = new Mapper(config);

            foreach(var item in empList)
            {
                employeeWrappersList.Add(mapper.Map<EmployeeWrapper>(item));
            }

            return employeeWrappersList;
        }
    }
}
