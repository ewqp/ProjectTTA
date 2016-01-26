using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Storage;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _booksRepository;

        public BookService(IBookRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public BookInfo Add(BookInfo book)
        {
            if (book.Title == null)
            {
                throw new ArgumentException("You must add the title.");
            }

            var booksDb = _booksRepository.Persist(book);
            if (booksDb != null && booksDb.Id.HasValue)
            {
                return Get(booksDb.Id.Value);
            }

            return null;
        }

        public void Remove(BookInfo book)
        {
            _booksRepository.Remove(book);
        }

        public void Update(BookInfo book)
        {
            _booksRepository.Persist(book);
        }

        public BookInfo Get(int id)
        {
            return _booksRepository.GetBookById(id);
        }

        public IEnumerable<BookInfo> GetAllBooks()
        {
            return _booksRepository.GetAll();
        }




    }
}
