using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Model;

namespace Library.Storage
{
    public class BookGenreRepository : Repository<BookGenre>, IBookGenreRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public BookGenreRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public BookGenre GetBookGenreById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenre>()
                    .FirstOrDefault(u => u.IdGenre == id);
            }
        }
        public BookGenre TakeBookGenreData(string genre)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenre>()
                    .FirstOrDefault(u => u.Genre == genre);
            }
        }

        public IEnumerable<BookGenre> GetAllBookGenres()
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenre>()
                    .ToList();
            }
        }
    }
}