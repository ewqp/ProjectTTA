using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Storage
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookById(int id);
        Book TakeBookData(string title);
        IEnumerable<Book> GetAllBooks();
    }
}
