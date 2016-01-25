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
    public class UserServiceTests
    {
        private IUserRepository _usersRepository;
        private UserService _sut;

        [SetUp]
        public void SetUp()
        {
            _usersRepository = A.Fake<IUserRepository>();
            _sut = new UserService(_usersRepository);
        }

        [Test]
        public void Add_ShouldPersistUserInRepository()
        {
            var user = new User
            {
                UserName = "name1",
                UserSurname = "surname1",
                UserPassword = "password1",
                UserEmail = "email@com.pl",
                IdUserRole = 1
            };

            _sut.Add(user);

            A.CallTo(() => _usersRepository.Persist(A<User>._))
                .MustHaveHappened();
        }

        [Test]
        public void Add_ShouldOccurException_WhenNoInformations()
        {
            var user = new User();

            Assert.Throws<ArgumentException>(() => _sut.Add(user));
        }

        [Test]
        public void Add_ShouldReturnNull_WhenPersistReturnedNull()
        {
            var user = new User
            {
                UserName = "name1",
                UserSurname = "surname1",
                UserPassword = "password1",
                UserEmail = "email@com.pl",
                IdUserRole = 1
            };
            A.CallTo(() => _usersRepository.Persist(A<User>._))
                .Returns(null);

            var result = _sut.Add(user);

            A.CallTo(() => _usersRepository.Persist(A<User>._))
                .MustHaveHappened();
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Add_ShouldReturnNotNullAndCallGet_WhenPersistReturnedNotNull()
        {
            var user = new User
            {
                Id = 1,
                UserName = "name1",
                UserSurname = "surname1",
                UserPassword = "password1",
                UserEmail = "email@com.pl",
                IdUserRole = 1
            };
            A.CallTo(() => _usersRepository.Persist(A<User>._))
               .Returns(user);

            var result = _sut.Add(user);

            A.CallTo(() => _usersRepository.Persist(A<User>._))
                .MustHaveHappened();
            Assert.That(result, Is.Not.Null);
            A.CallTo(() => _usersRepository.GetUserById(A<int>._))
                .MustHaveHappened();
        }

        [Test]
        public void Remove_ShouldCallRemoveFromRepository()
        {
            var user = new User();

            _sut.Remove(user);

            A.CallTo(() => _usersRepository.Remove(A<User>._))
                .MustHaveHappened();
        }

        [Test]
        public void Get_ShouldCallGetFromRepository()
        {
            _sut.Get(int.MaxValue);

            A.CallTo(() => _usersRepository.GetUserById(A<int>._)).
                MustHaveHappened();
        }

        [Test]
        public void GetAll_ShouldCallGetAllFromRepository()
        {
            _sut.GetAllUsers();

            A.CallTo(() => _usersRepository.GetAll())
                .MustHaveHappened();
        }
        [Test]
        public void Remove_ShouldRemoveUserFromRepository()
        {
            var user = new User();

            _sut.Remove(user);

            A.CallTo(() => _usersRepository.Remove(A<User>._))
                .MustHaveHappened();
        }
        [Test]
        public void UpdateBudget_Should_Persist_Budget_In_Repository()
        {
            var user = new User();

            _sut.Update(user);

            A.CallTo(() => _usersRepository.Persist(user))
                .MustHaveHappened();
        }


    }
}