using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Registration.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
            :base("Connection")
        {
            DropCreateDatabaseIfModelChanges<UserContext> d = new DropCreateDatabaseIfModelChanges<UserContext>();
            Database.SetInitializer<UserContext>(d);
        }

        public System.Data.Entity.DbSet<Registration.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Registration.Models.Userdemo> Userdemoes { get; set; }
    }
}