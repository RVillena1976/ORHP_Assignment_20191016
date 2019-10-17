using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_API.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<System.DateTime> HireDt { get; set; }

        public string DepartmentName { get; set; }
    }
}