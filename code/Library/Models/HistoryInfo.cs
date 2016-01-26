using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class HistoryInfo : ModelBase
    {
        private string authorName;
        private string userName;
        private string accountName;
        private string avaliable;
        public int IdHistory;
        public int Returned { get; set; }
        public int IdBook { get; set; }
        public DateTime ActionDate { get; set; }
        public int IdAuthor { get; set; }
        public int IdAccount { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string FullAuthorName { get { authorName = string.Format("{0} {1}", AuthorName, AuthorSurname); return authorName; } set { authorName = value; } }        
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string FullUserName { get { userName = string.Format("{0} {1}", UserName, UserSurname); return userName; } set { userName = value; } }
        public string AccountName { get; set; }
        public string AccountSurname { get; set; }
        public string FullAccountName { get { accountName = string.Format("{0} {1}", AccountName, AccountSurname); return accountName; } set { accountName = value; } }
        public string Avaliable { get { avaliable = Returned == 0 ? "UNAVALIABLE" : "AVALIABLE"; return avaliable; } set { avaliable = value; } }
        public virtual BookInfo Book { get; set; }
        public virtual AuthorInfo Author { get; set; }
        public virtual AccountInfo Account { get; set; }
    }
}
