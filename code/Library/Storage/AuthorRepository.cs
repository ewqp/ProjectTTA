using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Library.Models;

namespace Library.Storage
{
    public class AuthorRepository : Repository<AuthorInfo>, IAuthorRepository
    {
        private readonly Func<DbContext> _contextFactory;

        public AuthorRepository(Func<DbContext> contextFactory) : base(contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public AuthorInfo GetAuthorById(int id)
        {
            using (var context = _contextFactory())
            {
                return context.Set<AuthorInfo>()
                    .FirstOrDefault(u => u.IdAuthor == id);
            }
        }
        public AuthorInfo TakeAuthorData(string name, string surname)
        {
            using (var context = _contextFactory())
            {
                return context.Set<AuthorInfo>()
                    .FirstOrDefault(u => u.AuthorName == name && u.AuthorSurname == surname);
            }
        }

        public IEnumerable<AuthorInfo> GetAllAuthors()
        {
            using (var context = _contextFactory())
            {
                return context.Set<AuthorInfo>()
                    .ToList();
            }
        }
    }
}