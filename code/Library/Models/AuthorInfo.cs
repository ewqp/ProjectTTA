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
        public string Name { get; set; }
        public string Surname { get; set; }

        public string FullAuthorName { get { name = string.Format("{0} {1}", AuthorName, AuthorSurname); return name; } set { name = value; } }
    }
}
