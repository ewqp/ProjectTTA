using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Services
{
    public interface IBookGenreService
    {
        BookGenre Add(BookGenre genre);
        void Remove(BookGenre genre);
        void Update(BookGenre genre);
        BookGenre Get(int id);
        IEnumerable<BookGenre> GetAllGenres();
    }
}
