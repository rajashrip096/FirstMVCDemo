using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCDemo.Models
{
    public class Student1
    {
        [Required(ErrorMessage = "Rollno is required")]
        [Display(Name = "Student rollno")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "name is required")]
        [Display(Name = "Emp Full Name")]
        [MaxLength(40, ErrorMessage = "length should be less than 40 character")]
        [MinLength(2, ErrorMessage = "min legth is 2 character")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Percentage is required")]
        public int Percentage { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        public int Contact { get; set;}
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
