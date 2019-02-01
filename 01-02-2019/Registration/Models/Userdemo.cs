using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class Userdemo
    {
        public int UserdemoId { get; set; }
        public int Userid { get; set; }
        public virtual User User { get; set; }
        [Required]
        [Display(Name = "Enter Student Name")]
        [DataType(DataType.Text, ErrorMessage = "Enter a valid name")]
        public string sname { get; set; }

        [Required]
        [Display(Name = "Enter Student Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Enter a valid email")]
        public string semail { get; set; }
        public Gender Genderlist { get; set; }

    }
    public enum Gender
    {
        Male,
        Female,
    }
}