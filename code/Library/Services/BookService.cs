using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
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

        public Book Add(Book book)
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

        public void Remove(Book book)
        {
            _booksRepository.Remove(book);
        }

        public void Update(Book book)
        {
            _booksRepository.Persist(book);
        }

        public Book Get(int id)
        {
            return _booksRepository.GetBookById(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _booksRepository.GetAll();
        }




    }
}
