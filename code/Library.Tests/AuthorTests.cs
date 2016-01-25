using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logics;
using Library.Models;
using NUnit.Framework;

namespace Library.Tests
{
    [TestFixture]
    class AuthorTests
    {
        private DBAuthor _dbAuthor = new DBAuthor();
        private List<Models.AuthorInfo> _authorList;

        [Test]
        public void Add_Author_Should_Add_Author_to_Database()
        {
            String response = _dbAuthor.AddAuthor("imie", "nazwisko");
            Assert.That(response, Is.EqualTo("Author added succesfully."));

        }

        public void Add_Author_With_Too_Many_Arguments_Should_Fail()
        {
            String response = _dbAuthor.AddAuthor("imie", "nazwisko", "cosjeszcze");
            Assert.That(response, Is.EqualTo("Author added succesfully."));

        }
    }
}
