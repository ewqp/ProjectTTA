using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IAuthorService
    {
        AuthorInfo Add(AuthorInfo author);
        void Remove(AuthorInfo author);
        void Update(AuthorInfo author);
        AuthorInfo Get(int id);
        IEnumerable<AuthorInfo> GetAllAuthors();
    }
}
