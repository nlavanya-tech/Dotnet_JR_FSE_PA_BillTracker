
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillTracker.Entities
{
    public class User
    {
       
       


        [Key]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "User Name")]
        [MaxLength(50, ErrorMessage = "User Name Cannot exceed 50 Characters")]

        public string UserName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [MaxLength(50, ErrorMessage = "Password Cannot exceed 50 Characters")]

        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [MaxLength(50, ErrorMessage = "Confirm Password Cannot exceed 50 Characters")]
        public string ConfirmPassword { get; set; }


        [Required]
        [RegularExpression(@"[a-z0-9][-a-z0-9._]+@([-a-z0-9]+[.])+[a-z]{2,5}$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Emai Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public UserType UserType { get; set; }

    }
}
