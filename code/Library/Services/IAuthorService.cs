using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Services
{
    public interface IAuthorService
    {
        Author Add(Author author);
        void Remove(Author author);
        void Update(Author author);
        Author Get(int id);
        IEnumerable<Author> GetAllAuthors();
    }
}
