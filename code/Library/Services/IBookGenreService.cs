using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IBookGenreService
    {
        BookGenreInfo Add(BookGenreInfo genre);
        void Remove(BookGenreInfo genre);
        void Update(BookGenreInfo genre);
        BookGenreInfo Get(int id);
        IEnumerable<BookGenreInfo> GetAllGenres();
    }
}
