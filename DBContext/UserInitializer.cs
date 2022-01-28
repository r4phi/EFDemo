using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Model;

namespace EFDemo.DBContext
{
    class UserInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            IList<User> defaultUsers = new List<User>();

            defaultUsers.Add(new User
            {
                Name = "Andi Arbeit",
                Email = "andi@arbei.at"
            });

            defaultUsers.Add(new User
            {
                Name = "Erkan Alles",
                Email = "erkan@alles.at"
            });

            context.Users.AddRange(defaultUsers);

            base.Seed(context);
        }
    }
}
