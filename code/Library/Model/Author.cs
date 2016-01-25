using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Author : ModelBase
    {
        public int IdAuthor { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
    }
}
