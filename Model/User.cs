using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.Model
{
    class User //1 (Password: n-Seite)
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<AccessData> AccessData { get; set; } = new List<AccessData>(); //Referenz auf n-Seite
    }
}
