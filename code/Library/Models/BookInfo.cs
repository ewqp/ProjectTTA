using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookInfo : EntityModel.Book
    {
        private string name;      
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string FullAuthorName { get { name = string.Format("{0} {1}", AuthorName, AuthorSurname); return name; } set { name = value; } }        
        public string Genre { get; set; }        
    }
}
