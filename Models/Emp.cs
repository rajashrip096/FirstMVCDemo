using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCDemo.Models
{
    public class Emp
    {
        [Required(ErrorMessage="Id is required")]
        [Display(Name="Emp Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required")]
        [Display(Name = "Emp Full Name")]
        [MaxLength(40, ErrorMessage = "length should be less than 40 character")]
        [MinLength(2, ErrorMessage = "min legth is 2 character")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage="email id is not in proper formmat")]
            public string Email { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        public int Contact { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }
}
