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
    public class BookGenreServiceTests
    {
        private IBookGenreRepository _genresRepository;
        private BookGenreService _sut;

        [SetUp]
        public void SetUp()
        {
            _genresRepository = A.Fake<IBookGenreRepository>();
            _sut = new BookGenreService(_genresRepository);
        }

        [Test]
        public void Add_Should_Persist_Genre_in_Repository()
        {
            var genre = new BookGenre
            {
                Genre = "genre",

            };

            _sut.Add(genre);

            A.CallTo(() => _genresRepository.Persist(A<BookGenre>._))
                .MustHaveHappened();
        }

        [Test]
        public void Add_Should_Throw_Exception_When_No_Information()
        {
            var genre = new BookGenre();

            Assert.Throws<ArgumentException>(() => _sut.Add(genre));
        }

        [Test]
        public void Add_Should_Return_Null_When_Persist_Returned_Null()
        {
            var genre = new BookGenre
            {
                Genre = "genre",

            };
            A.CallTo(() => _genresRepository.Persist(A<BookGenre>._))
                .Returns(null);

            var result = _sut.Add(genre);

            A.CallTo(() => _genresRepository.Persist(A<BookGenre>._))
                .MustHaveHappened();
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Remove_Should_Call_Remove_From_Repository()
        {
            var genre = new BookGenre();

            _sut.Remove(genre);

            A.CallTo(() => _genresRepository.Remove(A<BookGenre>._))
                .MustHaveHappened();
        }

        [Test]
        public void Get_Should_Call_Get_From_Repository()
        {
            _sut.Get(int.MaxValue);

            A.CallTo(() => _genresRepository.GetBookGenreById(A<int>._)).
                MustHaveHappened();
        }

        [Test]
        public void GetAll_Should_Call_GetAll_From_Repository()
        {
            _sut.GetAllGenres();

            A.CallTo(() => _genresRepository.GetAll())
                .MustHaveHappened();
        }
        [Test]
        public void Remove_ShouldRemoveUserFromRepository()
        {
            var genre = new BookGenre();

            _sut.Remove(genre);

            A.CallTo(() => _genresRepository.Remove(A<BookGenre>._))
                .MustHaveHappened();
        }
        [Test]
        public void Update_Genre_Should_Persist_Genre_In_Repository()
        {
            var genre = new BookGenre();

            _sut.Update(genre);

            A.CallTo(() => _genresRepository.Persist(genre))
                .MustHaveHappened();
        }


    }
}