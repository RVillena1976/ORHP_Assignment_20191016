using CRUD_WebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CRUD_WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeViewModel> employList = new List<EmployeeViewModel>();
            HttpResponseMessage response = GlobalVariables.APIClient.GetAsync("Employees").Result;

            //Also works
            //if (response.IsSuccessStatusCode)
            //{
            //    var r = response.Content.ReadAsStringAsync().Result;
            //    employList = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(r);
            //}

            employList = response.Content.ReadAsAsync<List<EmployeeViewModel>>().Result;

            return View(employList);
        }

        public ActionResult AddEdit(int id = 0)
        {
            List<DepartmentViewModel> departList = new List<DepartmentViewModel>();
            HttpResponseMessage departResponse = GlobalVariables.APIClient.GetAsync("Departments").Result;
            departList = departResponse.Content.ReadAsAsync<List<DepartmentViewModel>>().Result;
            ViewBag.DepartList = new SelectList(departList, "DepartmentID", "DepartmentNm");

            if (id == 0)
                return View(new EmployeeViewModel());
            else
            {   
                HttpResponseMessage response = GlobalVariables.APIClient.GetAsync("Employees/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<EmployeeViewModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddEdit(EmployeeViewModel employVM)
        {
            if (employVM.EmployeeID == 0)
            {
                HttpResponseMessage response = GlobalVariables.APIClient.PostAsJsonAsync("Employees", employVM).Result;
                TempData["SuccessMessage"] = "SAVED Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.APIClient.PutAsJsonAsync("Employees/" + employVM.EmployeeID, employVM).Result;
                TempData["SuccessMessage"] = "SAVED Successfully";
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.APIClient.DeleteAsync("Employees/" + id).Result;
            TempData["SuccessMessage"] = "DELETED Successfully";
            return RedirectToAction("Index");
        }
    }
}