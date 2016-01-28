using System;
using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Library.Models;
using Library.Services;
using Library.Storage;

namespace Library.Tests.Services
{
    [TestFixture]
    public class AuthorServiceTests
    {
        private IAuthorRepository _authorsRepository;
        private AuthorService _sut;

        [SetUp]
        public void SetUp()
        {
            _authorsRepository = A.Fake<IAuthorRepository>();
            _sut = new AuthorService(_authorsRepository);
        }

        [Test]
        public void Add_Should_Persist_Author_in_Repository()
        {
            var author = new AuthorInfo
            {
                AuthorName = "name",
                AuthorSurname = "surname",
            };

            _sut.Add(author);

            A.CallTo(() => _authorsRepository.Persist(A<AuthorInfo>._))
                .MustHaveHappened();
        }

        [Test]
        public void Add_Should_Throw_Exception_When_No_Informations()
        {
            var author = new AuthorInfo();

            Assert.Throws<ArgumentException>(() => _sut.Add(author));
        }

        [Test]
        public void Add_Should_Return_Null_When_Persist_Returned_Null()
        {
            var author = new AuthorInfo
            {
                AuthorName = "name",
                AuthorSurname = "surname",

            };
            A.CallTo(() => _authorsRepository.Persist(A<AuthorInfo>._))
                .Returns(null);

            var result = _sut.Add(author);

            A.CallTo(() => _authorsRepository.Persist(A<AuthorInfo>._))
                .MustHaveHappened();
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Remove_Should_Call_Remove_From_Repository()
        {
            var author = new AuthorInfo();

            _sut.Remove(author);

            A.CallTo(() => _authorsRepository.Remove(A<AuthorInfo>._))
                .MustHaveHappened();
        }

        [Test]
        public void Get_Should_Call_Get_From_Repository()
        {
            _sut.Get(int.MaxValue);

            A.CallTo(() => _authorsRepository.GetAuthorById(A<int>._)).
                MustHaveHappened();
        }

        [Test]
        public void GetAll_Should_Call_GetAll_From_Repository()
        {
            _sut.GetAllAuthors();

            A.CallTo(() => _authorsRepository.GetAll())
                .MustHaveHappened();
        }
        [Test]
        public void Remove_ShouldRemoveUserFromRepository()
        {
            var author = new AuthorInfo();

            _sut.Remove(author);

            A.CallTo(() => _authorsRepository.Remove(A<AuthorInfo>._))
                .MustHaveHappened();
        }
        [Test]
        public void Update_AUthor_Should_Persist_Author_In_Repository()
        {
            var author = new AuthorInfo();

            _sut.Update(author);

            A.CallTo(() => _authorsRepository.Persist(author))
                .MustHaveHappened();
        }

    }
}