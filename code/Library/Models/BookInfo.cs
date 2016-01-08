using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookInfo
    {
        private string name;
        public int IdBook { get; set; }
        public string Title { get; set; }
        public int IdAuthor { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get { name = name = string.Format("{0} {1}", Name, Surname); return name; } set { name = value; } }
        public int IdGenre { get; set; }
        public string Genre { get; set; }
    }
}
