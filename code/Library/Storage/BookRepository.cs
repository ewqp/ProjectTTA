using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Model;

namespace Library.Storage
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public BookRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Book TakeBookData(string title)
        {
            using (var context = _contextFactory())
            {
                return context.Set<Book>()
                    .FirstOrDefault(u => u.Title == title);
            }
        }

        public Book GetBookById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<Book>()
                    .FirstOrDefault(u => u.IdBook == id);
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            using (var context = _contextFactory())
            {
                return context.Set<Book>()
                    .ToList();
            }
        }
    }
}