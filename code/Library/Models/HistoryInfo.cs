﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class HistoryInfo : EntityModel.History
    {
        private string authorName;
        private string userName;
        private string accountName;
<<<<<<< HEAD
        private string avaliable;
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
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
<<<<<<< HEAD
        public string Avaliable { get { avaliable = Returned == 0 ? "UNAVALIABLE" : "AVALIABLE"; return avaliable; } set { avaliable = value; } }
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
    }
}