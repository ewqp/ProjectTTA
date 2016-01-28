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
    public class AccountServicesTests
    {
        private IAccountRepository _accountsRepository;
        private AccountServices _sut;

        [SetUp]
        public void SetUp()
        {
            _accountsRepository = A.Fake<IAccountRepository>();
            _sut = new AccountServices(_accountsRepository);
        }

        [Test]
        public void Add_Should_Persist_Account_in_Repository()
        {
            var account = new AccountInfo
            {
                AccountName = "name",
                AccountSurname = "surname",
                AccountEmail = "email",
            };

            _sut.Add(account);

            A.CallTo(() => _accountsRepository.Persist(A<AccountInfo>._))
                .MustHaveHappened();
        }

        [Test]
        public void Add_Should_Throw_Exception_When_No_Informations()
        {
            var account = new AccountInfo();
            Assert.Throws<ArgumentException>(() => _sut.Add(account));
        }

        [Test]
        public void Add_Should_Return_Null_When_Persist_Returned_Null()
        {
            var account = new AccountInfo
            {
                AccountName = "name",
                AccountSurname = "surname",
                AccountEmail = "email",

            };
            A.CallTo(() => _accountsRepository.Persist(A<AccountInfo>._)).Returns(null);

            var result = _sut.Add(account);

            A.CallTo(() => _accountsRepository.Persist(A<AccountInfo>._))
                .MustHaveHappened();
            Assert.That(result, Is.Null);
        }

        [Test]
        public void Remove_Should_Call_Remove_From_Repository()
        {
            var account = new AccountInfo();

            _sut.Remove(account);

            A.CallTo(() => _accountsRepository.Remove(A<AccountInfo>._)).MustHaveHappened();
        }

        [Test]
        public void Get_Should_Call_Get_From_Repository()
        {
            _sut.Get(int.MaxValue);

            A.CallTo(() => _accountsRepository.GetAccountById(A<int>._)).
                MustHaveHappened();
        }

        [Test]
        public void GetAll_Should_Call_GetAll_From_Repository()
        {
            _sut.GetAllAccounts();

            A.CallTo(() => _accountsRepository.GetAll())
                .MustHaveHappened();
        }

        [Test]
        public void Remove_ShouldRemoveUserFromRepository()
        {
            var account = new AccountInfo();

            _sut.Remove(account);

            A.CallTo(() => _accountsRepository.Remove(A<AccountInfo>._))
                .MustHaveHappened();
        }

        [Test]
        public void Update_Account_Should_Persist_Author_In_Repository()
        {
            var account = new AccountInfo();

            _sut.Update(account);

            A.CallTo(() => _accountsRepository.Persist(account))
                .MustHaveHappened();
        }
    }
}
