using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Student.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
            :base("Connection")
        {
            DropCreateDatabaseIfModelChanges<UserContext> d = new DropCreateDatabaseIfModelChanges<UserContext>();
            Database.SetInitializer<UserContext>(d);
        }

        public System.Data.Entity.DbSet<Student.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<Student.Models.Dept> Depts { get; set; }

        public System.Data.Entity.DbSet<Student.Models.Stud> Studs { get; set; }
    }
}