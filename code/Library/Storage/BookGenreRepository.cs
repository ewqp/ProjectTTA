using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Models;

namespace Library.Storage
{
    public class BookGenreRepository : Repository<BookGenreInfo>, IBookGenreRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public BookGenreRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public BookGenreInfo GetBookGenreById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenreInfo>()
                    .FirstOrDefault(u => u.IdGenre == id);
            }
        }
        public BookGenreInfo TakeBookGenreData(string genre)
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenreInfo>()
                    .FirstOrDefault(u => u.Genre == genre);
            }
        }

        public IEnumerable<BookGenreInfo> GetAllBookGenres()
        {
            using (var context = _contextFactory())
            {
                return context.Set<BookGenreInfo>()
                    .ToList();
            }
        }
    }
}