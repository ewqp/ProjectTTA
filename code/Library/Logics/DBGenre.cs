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
    }
}
