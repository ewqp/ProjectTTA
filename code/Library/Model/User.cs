using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class User : ModelBase
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public int IdUserRole { get; set; }
        public string UserPassword { get; set; }

        public virtual UserRoles UserRoles { get; set; }
    }
}
