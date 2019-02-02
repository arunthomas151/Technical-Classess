using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }
        [Required]
        [Display(Name = "Enter Student Name")]
        [DataType(DataType.Text,ErrorMessage="Enter a Valid Student Name")]
        public string sname { get; set; }

        [Required]
        [Display(Name = "Enter Student Email")]
        [DataType(DataType.EmailAddress,ErrorMessage="Enter a Valid Student Email")]
        public string semail { get; set; }

        [Required]
        [Display(Name = "Enter Student Mobile Number")]
        [DataType(DataType.PhoneNumber,ErrorMessage="Enter a Valind Mobile Number")]
        public string smob { get; set; }

        [Required]
        [Display(Name = "Enetr Student Username")]
        [DataType(DataType.Text,ErrorMessage="Enetr a Valid Username")]
        public string suname { get; set; }

        [Required]
        [Display(Name = "Enetr Student Password")]
        [DataType(DataType.Password,ErrorMessage="Enetr a Valid Password")]
        public string spword { get; set; }
    }
}