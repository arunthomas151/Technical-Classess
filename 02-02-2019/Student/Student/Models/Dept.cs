using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Dept
    {
        public int DeptId { get; set; }

        
        [Required]
        [Display(Name = "Enter Department Name")]
        [DataType(DataType.Text,ErrorMessage="Enter a valid Department Name")]
        public string dname { get; set; }
    }
}