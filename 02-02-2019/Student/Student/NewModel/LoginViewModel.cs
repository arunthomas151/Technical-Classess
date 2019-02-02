using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Student.NewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="Enter Username")]
        [DataType(DataType.Text,ErrorMessage="Enter a Valid Username")]
        public string username { get; set; }
        [Required]
        [Display(Name="Enter Password")]
        [DataType(DataType.Password,ErrorMessage="Enter a Valid Password")]
        public string password { get; set; }
    }
}