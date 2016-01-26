using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class AccountInfo : ModelBase
    {
        private string name;
        public int IdAccount { get; set; }
        public string AccountName { get; set; }
        public string AccountSurname { get; set; }
        public string AccountEmail { get; set; }
        public string FullAccountName { get { name = string.Format("{0} {1}", AccountName, AccountSurname); return name; } set { name = value; } }
    }
}
