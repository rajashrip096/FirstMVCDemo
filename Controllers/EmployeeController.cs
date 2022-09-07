using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmpList()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee{Id=1,Name="Rakesh",Salary=34000},
                new Employee{Id=2,Name="Neha",Salary=40000},
                new Employee{Id=3,Name="Sam",Salary=37000},
                new Employee{Id=4,Name="Riya",Salary=20340},
                new Employee{Id=5,Name="Navin",Salary=21000},
                new Employee{Id=6,Name="Ram",Salary=38000},
                new Employee{Id=7,Name="Anil",Salary=65900},
            };
            ViewData["EmpList"] = empList;
            ViewBag.empList = empList;
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Emp emp)
        {
            return View();
        }
    }
}
