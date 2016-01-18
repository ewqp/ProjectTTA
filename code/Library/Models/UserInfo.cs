using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class UserInfo : EntityModel.User
    {
        private string name;
        public string FullUserName { get { name = string.Format("{0} {1}", Name, Surname); return name; } set { name = value; } }
        public string UserRole { get; set; }
    }
}
