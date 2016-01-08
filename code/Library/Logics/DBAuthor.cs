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

                foreach(var author in bookAuthors)
                {
                    booksInfo.Add(new Models.AuthorInfo
                    {
                        Name = author.Name,
                        Surname = author.Surname,
                        IdAuthor = author.IdAuthor
                    });
                }
            }

            catch (Exception ex)
            {

            }
            return booksInfo;
        }        
    }
}
