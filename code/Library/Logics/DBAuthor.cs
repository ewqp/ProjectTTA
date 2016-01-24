using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logics;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBAuthor
    {
        public string AddAuthor(string name, string surname)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newAuthor = new Author();
                    newAuthor.AuthorName = name;
                    newAuthor.AuthorSurname = surname;

                    con.Author.Add(newAuthor);
                    con.SaveChanges();
                    return "Author added succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// List of all authors in Database.
        /// </summary>
        public List<Models.AuthorInfo> GetAllAuthors()
        {
            var bookAuthors = new List<EntityModel.Author>();
            var booksInfo = new List<Models.AuthorInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    bookAuthors = con.Author.ToList();
                }

                foreach (var author in bookAuthors)
                {
                    booksInfo.Add(new Models.AuthorInfo
                    {
                        Name = author.AuthorName,
                        Surname = author.AuthorSurname,
                        IdAuthor = author.IdAuthor
                    });
                }
            }

            catch (Exception ex)
            {

            }
            return booksInfo;
        }

        public string UpdateAuthor(int idAuthor, string name, string surname)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var author = con.Author.FirstOrDefault(b => b.IdAuthor == idAuthor);
                    author.AuthorName = name;
                    author.AuthorSurname = surname;
                    con.SaveChanges();
                    return "Author updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        public string DeleteAuthor(int idAuthor)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var author = con.Author.FirstOrDefault(b => b.IdAuthor == idAuthor);
                    con.Author.Remove(author);
                    con.SaveChanges();
                    return "Author deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
