using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookInfo : ModelBase
    {
        private string name;
        public int IdBook { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public int IdGenre { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string FullAuthorName { get { name = string.Format("{0} {1}", AuthorName, AuthorSurname); return name; } set { name = value; } }        
        public string Genre { get; set; }
        public virtual AuthorInfo Author { get; set; }
        public virtual BookGenreInfo BookGenre { get; set; }
    }
}
