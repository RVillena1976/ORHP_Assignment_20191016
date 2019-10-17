using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD_API.Models;

namespace CRUD_API.Controllers
{
    public class EmployeesController : ApiController
    {
        private CRUDDBEntities db = new CRUDDBEntities();

        // GET: api/Employees
        public List<EmployeeViewModel> GetEmployees()
        {
            List<Employee> employeeList = db.Employees.ToList();
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            List<EmployeeViewModel> employeeVML = employeeList.Select(x => new EmployeeViewModel
            { EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                HireDt = x.HireDt,
                DepartmentID = x.DepartmentID,
                DepartmentName = x.Department.DepartmentNm }).OrderBy(x => x.LastName).ToList();

            return employeeVML;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(EmployeeViewModel))]
        public IHttpActionResult GetEmployee(int id)
        {
     
            Employee employee = db.Employees.SingleOrDefault(x => x.EmployeeID == id);

            if (employee == null)
            {
                return NotFound();
            }

            EmployeeViewModel vm = new EmployeeViewModel();
            vm.EmployeeID = employee.EmployeeID;
            vm.FirstName = employee.FirstName;
            vm.LastName = employee.LastName;
            vm.HireDt = employee.HireDt;
            vm.DepartmentID = employee.DepartmentID;
            vm.DepartmentName = employee.Department.DepartmentNm;

            return Ok(vm);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EmployeeID)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.EmployeeID }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.EmployeeID == id) > 0;
        }
    }
}