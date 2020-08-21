using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace BillTracker.Entities
{
    public class UserLogin
    {

        [Required]
        [Display(Name = "User Name")]
        [MaxLength(50, ErrorMessage = "User Name Cannot exceed 50 Characters")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [MaxLength(50, ErrorMessage = "Password Cannot exceed 50 Characters")]
        public string Password { get; set; }
    }
}
