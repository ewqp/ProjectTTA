using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Storage
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorById(int id);
        Author TakeAuthorData(string name, string surname);
        IEnumerable<Author> GetAllAuthors();

    }
}
