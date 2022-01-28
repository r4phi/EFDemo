using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    class AccessData //n (User: 1-Seite)
    {
        public int Id { get; set; }
        public string LoginName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public int UserID { get; set; } //FK
        public User User { get; set; } //Referenz auf 1-er Seite
    }
}
