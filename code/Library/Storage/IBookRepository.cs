using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Storage
{
    public interface IBookRepository : IRepository<BookInfo>
    {
        BookInfo GetBookById(int id);
        BookInfo TakeBookData(string title);
        IEnumerable<BookInfo> GetAllBooks();
    }
}
