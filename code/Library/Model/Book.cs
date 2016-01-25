using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Book : ModelBase
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public int IdGenre { get; set; }
        //public string FullAuthorName { get { name = string.Format("{0} {1}", AuthorName, AuthorSurname); return name; } set { name = value; } } 
        public virtual Author Author { get; set; }
        public virtual BookGenre BookGenre { get; set; }
    }
}
