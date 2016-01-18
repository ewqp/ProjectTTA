using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class UserAllInfo
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int IdUserRole { get; set; }
        public string UserRole { get; set; }
        public string UserPassword { get; set; }
    }
}
