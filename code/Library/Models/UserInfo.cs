using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class UserInfo : ModelBase
    {
        private string name;
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public int IdUserRole { get; set; }
        public string UserPassword { get; set; }
        public string FullUserName { get { name = string.Format("{0} {1}", UserName, UserSurname); return name; } set { name = value; } }      
        public string UserRole { get; set; }
        public virtual UserRolesInfo UserRoles { get; set; }
    }
}
