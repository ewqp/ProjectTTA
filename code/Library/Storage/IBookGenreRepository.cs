using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Storage
{
    public interface IBookGenreRepository : IRepository<BookGenreInfo>
    {
        BookGenreInfo GetBookGenreById(int id);
        BookGenreInfo TakeBookGenreData(string genre);
        IEnumerable<BookGenreInfo> GetAllBookGenres();

    }
}
