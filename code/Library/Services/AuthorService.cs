using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Storage;

namespace Library.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorsRepository;

        public AuthorService(IAuthorRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        public AuthorInfo Add(AuthorInfo author)
        {
            if (author.AuthorName == null || author.AuthorSurname == null)
            {
                throw new ArgumentException("The author has to have all informations.");
            }

            var authorDb = _authorsRepository.Persist(author);
            if (authorDb != null && authorDb.Id.HasValue)
            {
                return Get(authorDb.Id.Value);
            }

            return null;
        }

        public void Remove(AuthorInfo author)
        {
            _authorsRepository.Remove(author);
        }

        public void Update(AuthorInfo author)
        {
            _authorsRepository.Persist(author);
        }

        public AuthorInfo Get(int id)
        {
            return _authorsRepository.GetAuthorById(id);
        }

        public IEnumerable<AuthorInfo> GetAllAuthors()
        {
            return _authorsRepository.GetAll();
        }




    }
}
