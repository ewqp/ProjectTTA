using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBGenre
    {

        public string AddBookGenre(string name)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newBookGenre = new BookGenre();
                    newBookGenre.Genre = name;

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
        public List<EntityModel.BookGenre> GetAllBookGenres()
        {
            var bookTypes = new List<EntityModel.BookGenre>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    bookTypes = con.BookGenre.ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return bookTypes;
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
