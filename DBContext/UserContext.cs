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
        public DbSet<User> Users { get; set; }
    }
}
