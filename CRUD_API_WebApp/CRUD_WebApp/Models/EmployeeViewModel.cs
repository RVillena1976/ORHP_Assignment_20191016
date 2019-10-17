using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_WebApp.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name: Required")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name: Required")]
        public string FirstName { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage ="Department: Required")]
        public int DepartmentID { get; set; }
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> HireDt { get; set; }
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
    }
}