using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Model;

namespace Library.Storage
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public AuthorRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Author GetAuthorById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<Author>()
                    .FirstOrDefault(u => u.IdAuthor == id);
            }
        }
        public Author TakeAuthorData(string name, string surname)
        {
            using (var context = _contextFactory())
            {
                return context.Set<Author>()
                    .FirstOrDefault(u => u.AuthorName == name && u.AuthorSurname == surname);
            }
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            using (var context = _contextFactory())
            {
                return context.Set<Author>()
                    .ToList();
            }
        }
    }
}