using CRUD_API.Controllers;
using CRUD_API.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CRUD_API.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllEmployees()
        {
            EmployeesController ec = new EmployeesController();
            var testEmployees = GetTestEmployees();
            var result = ec.GetEmployees();
            Assert.AreEqual(testEmployees.Count, result.Count);
        }

        public void GetAllDepartments()
        {
            DepartmentsController dc = new DepartmentsController();
            var testDepartments = GetTestDepartments();
            var result = dc.GetDepartments();
            Assert.AreEqual(testDepartments.Count, result.Count);
        }

        private List<EmployeeViewModel> GetTestEmployees()
        {
            var testEmployees = new List<EmployeeViewModel>();
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 1, LastName = "Smith", FirstName = "John", DepartmentID = 1, HireDt = Convert.ToDateTime("2019-01-01 00:00:00.000"), DepartmentName = "Sales" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 2, LastName = "James", FirstName = "Jack", DepartmentID = 1, HireDt = Convert.ToDateTime("2019-02-01 00:00:00.000"), DepartmentName = "Sales" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 3, LastName = "Wayne", FirstName = "Bruce", DepartmentID = 2, HireDt = Convert.ToDateTime("2019-03-01 00:00:00.000"), DepartmentName = "Service" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 4, LastName = "Kent", FirstName = "Clark", DepartmentID = 2, HireDt = Convert.ToDateTime("2019-03-15 00:00:00.000"), DepartmentName = "Service" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 5, LastName = "Hamilton", FirstName = "James", DepartmentID = 3, HireDt = Convert.ToDateTime("2019-04-01 00:00:00.000"), DepartmentName = "Marketing" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 6, LastName = "Burr", FirstName = "Aaron", DepartmentID = 3, HireDt = Convert.ToDateTime("2019-04-10 00:00:00.000"), DepartmentName = "Marketing" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 7, LastName = "Stark", FirstName = "Tony", DepartmentID = 4, HireDt = Convert.ToDateTime("2019-04-10 00:00:00.000"), DepartmentName = "Authorization" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 2002, LastName = "Adams", FirstName = "John", DepartmentID = 1, HireDt = Convert.ToDateTime("2019-11-26 00:00:00.000"), DepartmentName = "Sales" });
            testEmployees.Add(new EmployeeViewModel { EmployeeID = 3007, LastName = "Washington", FirstName = "George", DepartmentID = 4, HireDt = Convert.ToDateTime("2019-10-02 00:00:00.000"), DepartmentName = "Authorization" });

            return testEmployees;
        }

        private List<DepartmentViewModel> GetTestDepartments()
        {
            var testDepartments = new List<DepartmentViewModel>();
            testDepartments.Add(new DepartmentViewModel { DepartmentID = 1, DepartmentNm = "Sales" });
            testDepartments.Add(new DepartmentViewModel { DepartmentID = 2, DepartmentNm = "Service" });
            testDepartments.Add(new DepartmentViewModel { DepartmentID = 3, DepartmentNm = "Marketing" });
            testDepartments.Add(new DepartmentViewModel { DepartmentID = 4, DepartmentNm = "Authorization" });

            return testDepartments;
        }
    }
}
