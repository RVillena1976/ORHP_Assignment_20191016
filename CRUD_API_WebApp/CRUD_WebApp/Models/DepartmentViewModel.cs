using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_WebApp.Models
{
    public class DepartmentViewModel
    {
        public int DepartmentID { get; set; }
        public string DepartmentNm { get; set; }
    }
}