using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class Stud
    {
        public int StudId { get; set; }
        public int DeptId { get; set; }
        public virtual Dept Dept { get; set; }
        public int RegistrationId { get; set; }
        public virtual Registration Registration { get; set; }

    }
}