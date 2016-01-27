using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Models;

namespace Library.Storage
{
    public class BookRepository : Repository<BookInfo>, IBookRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public BookRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public BookInfo TakeBookData(string title)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookInfo>()
                    .FirstOrDefault(u => u.Title == title);
            }
        }

        public BookInfo GetBookById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookInfo>()
                    .FirstOrDefault(u => u.IdBook == id);
            }
        }

        public IEnumerable<BookInfo> GetAllBooks()
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookInfo>()
                    .ToList();
            }
        }
    }
}