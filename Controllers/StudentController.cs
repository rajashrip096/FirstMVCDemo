using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudList()
        {
            List<Student> stud = new List<Student>()
            {
                new Student{RollNo=1,Name="Rakesh",Percentage=90},
                new Student{RollNo=2,Name="Neha",Percentage=88},
                new Student{RollNo=3,Name="Sam",Percentage=80},
                new Student{RollNo=4,Name="Riya",Percentage=78},
                new Student{RollNo=5,Name="Navin",Percentage=95},
                new Student{RollNo=6,Name="Ram",Percentage=91},
                new Student{ RollNo=7, Name="Anil",Percentage=65},
            };
            ViewData["StudList"] = stud;
            ViewBag.empList = stud;
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student1 student)
        {
            return View();
        }
    }
}
