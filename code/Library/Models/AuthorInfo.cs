using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Library.Models
{
    public class AuthorInfo : EntityModel.Author
    {
        private string name;
        public string FullName { get { name = string.Format("{0} {1}", Name, Surname); return name; } set { name = value; } }
    }
}
