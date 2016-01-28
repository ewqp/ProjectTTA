using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBBookGenre
    {

        public string AddBookGenre(string name)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newBookGenre = new BookGenre();
                    newBookGenre.Genre = name;

                    //if(name != )
                    con.BookGenre.Add(newBookGenre);
                    con.SaveChanges();
                    return "Genre added succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
        /// <summary>
        /// List of all book genres in DB.
        /// </summary>
        public List<Models.BookGenreInfo> GetAllBookGenres()
        {
            var bookGenres = new List<BookGenre>();
            var genreInfo = new List<Models.BookGenreInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    bookGenres = con.BookGenre.ToList();
                }

                foreach (var genre in bookGenres)
                {
                    genreInfo.Add(new Models.BookGenreInfo
                    {
                        IdGenre = genre.IdGenre,
                        Genre = genre.Genre
                    });
                }
            }

            catch (Exception ex)
            {

            }

            return genreInfo;
        }

        public string UpdateBookGenre(int idGenre, string name)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var genre = con.BookGenre.FirstOrDefault(b => b.IdGenre == idGenre);
                    genre.Genre = name;

                    con.SaveChanges();
                    return "Genre updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string DeleteBookGenre(int idGenre)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var genre = con.BookGenre.FirstOrDefault(b => b.IdGenre == idGenre);
                    con.BookGenre.Remove(genre);
                    con.SaveChanges();
                    return "Genre deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
