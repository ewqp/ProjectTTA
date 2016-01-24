using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Logics;
using Library.Models;
using NUnit.Framework;
using System.Diagnostics;

namespace Library.Tests
{
    [TestFixture]
    class UsersTests
    {
        private DBUser _dbUser = new DBUser();
        private DBUserRoles _dbUserRole = new DBUserRoles();
        private List<UserInfo> _usersList;


        [Test]
        public void CreatingUser_Pass()
        {
            String response = _dbUser.AddUser("name1", "surname1", "email1@onet.pl", 1, "password1");
            Debug.WriteLine(response);
            Assert.That(response, Is.EqualTo("User added succesfully."));

        }

        [Test]
        public void CreatingUser_Error()
        {
            String response = _dbUser.AddUser("name1", "surname1", "email1@onet.pl", 3, "password1");
            Debug.WriteLine(response);
            Assert.That(response, Is.EqualTo("Role does not exist!"));

        }
        [Test]
        public void GetUsers_Pass()
        {
            _usersList = _dbUser.GetAllUsersInfo();
            Assert.That(_usersList.Count(), Is.EqualTo(2));
        }

        [Test]
        public void GetUsers_Empty()
        {
            _usersList = _dbUser.GetAllUsersInfo();
            Assert.That(_usersList.Count(), Is.EqualTo(0));
        }
        [Test]
        public void DeleteUser()
        {
            String response = _dbUser.DeleteUser(1);
            Debug.WriteLine(response);
            Assert.That(response, Is.EqualTo("User deleted succesfully."));
        }

    }
}
