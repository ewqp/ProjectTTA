using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IBookService
    {
        BookInfo Add(BookInfo book);
        void Remove(BookInfo book);
        void Update(BookInfo book);
        BookInfo Get(int id);
        IEnumerable<BookInfo> GetAllBooks();
    }
}
