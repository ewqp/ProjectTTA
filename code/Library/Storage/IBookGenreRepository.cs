using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;

namespace Library.Storage
{
    public interface IBookGenreRepository : IRepository<BookGenre>
    {
        BookGenre GetBookGenreById(int id);
        BookGenre TakeBookGenreData(string genre);
        IEnumerable<BookGenre> GetAllBookGenres();

    }
}
