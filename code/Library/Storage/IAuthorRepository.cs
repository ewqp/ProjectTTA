using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Storage
{
    public interface IAuthorRepository : IRepository<AuthorInfo>
    {
        AuthorInfo GetAuthorById(int id);
        AuthorInfo TakeAuthorData(string name, string surname);
        IEnumerable<AuthorInfo> GetAllAuthors();

    }
}
