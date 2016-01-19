using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class AccountInfo : EntityModel.Account
    {
        private string name;
        public string FullAccountName { get { name = string.Format("{0} {1}", AccountName, AccountSurname); return name; } set { name = value; } }
    }
}
