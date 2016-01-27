using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Library.Models
{
    public class AuthorInfo : ModelBase
    {
        private string name;
        public int IdAuthor { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string FullAuthorName { get { name = string.Format("{0} {1}", AuthorName, AuthorSurname); return name; } set { name = value; } }
    }
}
