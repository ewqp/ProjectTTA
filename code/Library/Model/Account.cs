using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Account : ModelBase
    {
        public string AccountName { get; set; }
        public string AccountSurname { get; set; }
        public string AccountEmail { get; set; }
    }
}
