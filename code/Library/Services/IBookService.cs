using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Services
{
    public interface IBookService
    {
        Book Add(Book book);
        void Remove(Book book);
        void Update(Book book);
        Book Get(int id);
        IEnumerable<Book> GetAllBooks();
    }
}
