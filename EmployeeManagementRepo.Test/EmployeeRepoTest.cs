using System;
using EmployeeManagementRepo.Employees;
using EmployeeManagementRepo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagementRepo.Test
{
    [TestClass]
    public class EmployeeRepoTest
    {
        BaseRepository<Employee> EmployeesRepo;

        [TestInitialize]
        public void TestSetup()
        {
            InitializeDB db = new InitializeDB();
            System.Data.Entity.Database.SetInitializer(db);
            EmployeesRepo = new BaseRepository<Employee>();
        }

        [TestMethod]
        public void GetEmployee_validScenario()
        {
            EmployeesManagementRepo managementRepo = new EmployeesManagementRepo();
            var result = managementRepo.GetEmployee(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Email, "Ashish.Kumar@ExamRoom.com");
        }

        [TestMethod]
        public void GetEmployeeList_validScenario()
        {
            EmployeesManagementRepo managementRepo = new EmployeesManagementRepo();
            var result = managementRepo.GetEmployees(1, "ExamRoom.AI", "Manager");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 2);
        }
    }
}
