using System;
using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Library.Model;
using Library.Services;
using Library.Storage;

namespace Library.Tests.Services
{
    [TestFixture]
    public class BookServiceTests
    {
        private IBookRepository _booksRepository;
        private BookService _sut;

        [SetUp]
        public void SetUp()
        {
            _booksRepository = A.Fake<IBookRepository>();
            _sut = new BookService(_booksRepository);
        }

        [Test]
        public void Add_Should_Persist_Book_In_Repository()
        {
            var book = new Book
            {
                Title = "name",
                IdAuthor = 1,
                IdGenre = 1,
            };

            _sut.Add(book);

            A.CallTo(() => _booksRepository.Persist(A<Book>._))
                .MustHaveHappened();
        }

        [Test]
        public void Add_Should_Throw_Exception_When_No_Informations()
        {
            var book = new Book();

            Assert.Throws<ArgumentException>(() => _sut.Add(book));
        }

        [Test]
        public void Add_Should_Return_Null_When_Persist_Returned_Null()
        {
            var book = new Book
            {
                Title = "name",
                IdAuthor = 1,
                IdGenre = 1,

            };
            A.CallTo(() => _booksRepository.Persist(A<Book>._))
                .Returns(null);

            var result = _sut.Add(book);

            A.CallTo(() => _booksRepository.Persist(A<Book>._))
                .MustHaveHappened();
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Remove_Should_Call_Remove_From_Repository()
        {
            var book = new Book();

            _sut.Remove(book);

            A.CallTo(() => _booksRepository.Remove(A<Book>._))
                .MustHaveHappened();
        }

        [Test]
        public void Get_Should_Call_Get_From_Repository()
        {
            _sut.Get(int.MaxValue);

            A.CallTo(() => _booksRepository.GetBookById(A<int>._)).
                MustHaveHappened();
        }

        [Test]
        public void GetAll_Should_Call_GetAll_From_Repository()
        {
            _sut.GetAllBooks();

            A.CallTo(() => _booksRepository.GetAll())
                .MustHaveHappened();
        }

        [Test]
        public void Remove_Should_Remove_User_From_Repository()
        {
            var book = new Book();

            _sut.Remove(book);

            A.CallTo(() => _booksRepository.Remove(A<Book>._))
                .MustHaveHappened();
        }

        [Test]
        public void Update_Book_Should_Persist_Book_In_Repository()
        {
            var book = new Book();

            _sut.Update(book);

            A.CallTo(() => _booksRepository.Persist(book))
                .MustHaveHappened();
        }


    }
}