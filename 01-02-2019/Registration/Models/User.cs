using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [Display(Name = "Enter Name")]
        [DataType(DataType.Text, ErrorMessage = "Enter a valid name")]
        public string ename { get; set; }

        [Required]
        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Enter Mobile Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Enter a valid mobile number")]
        public string mob { get;  set; }

        [Required]
        [Display(Name = "Enter your password")]
        [DataType(DataType.Password, ErrorMessage = "Enter a valid password")]
        public string pword { get; set; }
    }
}