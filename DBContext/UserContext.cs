using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.DBContext
{
    class UserContext : DbContext
    {

        public UserContext()
        {
            //Database.SetInitializer<UserContext>(new DropCreateDatabaseAlways<UserContext>());//jedes mal beim Starten, wird DB neu erzeugt
            //Database.SetInitializer<UserContext>(new DropCreateDatabaseIfModelChanges<UserContext>()); //wenn sich Model ändert --> DB neu erzeugt
            Database.SetInitializer<UserContext>(new UserInitializer());
        }

        public DbSet<User> Users { get; set; }
    }
}
