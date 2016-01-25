using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Rented : ModelBase
    {
        public int IdBook { get; set; }
        public int IdAuthor { get; set; }
        public DateTime RentDate { get; set; }
        public int IdAccount { get; set; }

        public virtual Author Author { get; set; }
        public virtual Account Account { get; set; }

    }
}

