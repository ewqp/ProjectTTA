using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;
using Library.Models;

namespace Library.Logics
{
    public class DBUser
    {
<<<<<<< HEAD
        /// <summary>
        /// Adding new user
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        public string AddUser(string name, string surname, string email, int idUserRole, string userPassword)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newUser = new User();
<<<<<<< HEAD
                    newUser.UserName = name;
                    newUser.UserSurname = surname;
                    newUser.UserEmail = email;
=======
                    newUser.Name = name;
                    newUser.Surname = surname;
                    newUser.Email = email;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                    newUser.IdUserRole = idUserRole;
                    newUser.UserPassword = userPassword;

                    if (idUserRole == 0)
                        return "Role does not exist!";
                    con.User.Add(newUser);
                    con.SaveChanges();
                    return "User added succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

<<<<<<< HEAD
        /// <summary>
        /// Edit user in User
        /// </summary>
        public string UpdateUser(int idUser, string name, string surname, string email, int idRole, string password)
        {
=======
        public List<Models.UserAllInfo> GetAllUsersInfo()
        {
            var allUsersInfo = new List<Models.UserAllInfo>();

>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
            try
            {
                using (var con = new EntitiesLib())
                {
<<<<<<< HEAD
                    var user = con.User.FirstOrDefault(u => u.IdUser == idUser);
                    user.UserName = name;
                    user.UserSurname = surname;
                    user.UserEmail = email;                    
                    user.IdUserRole = idRole;
                    user.UserPassword = password;
=======
                    List<EntityModel.User> allUsers = con.User.ToList();

                    if (allUsers.Count == 0)
                        return allUsersInfo;

                    for (int i = 0; i < allUsers.Count; i++)
                    {
                        Models.UserAllInfo userInfo = new Models.UserAllInfo();

                        userInfo.IdUser = allUsers[i].IdUser;
                        userInfo.Name = allUsers[i].Name;
                        userInfo.Surname = allUsers[i].Surname;
                        userInfo.Email = allUsers[i].Email;
                        userInfo.UserPassword = allUsers[i].UserPassword;
                        userInfo.IdUserRole = allUsers[i].IdUserRole;
                        userInfo.UserRole = con.UserRole.FirstOrDefault(g => g.IdUserRole == userInfo.IdUserRole).UserRole1;

                        allUsersInfo.Add(userInfo);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return allUsersInfo;
        }
        public string UpdateUser(int idUser, string name, string surname, string email, string password, int idRole)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var user = con.User.FirstOrDefault(b => b.IdUser == idUser);
                    user.Name = name;
                    user.Surname = surname;
                    user.Email = email;
                    user.UserPassword = password;
                    user.IdUserRole = idRole;
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                    con.SaveChanges();
                    return "User updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
<<<<<<< HEAD

        /// <summary>
        /// Delete user from User
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        public string DeleteUser(int idUser)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
<<<<<<< HEAD
                    var User = con.User.FirstOrDefault(u => u.IdUser == idUser);
=======
                    var User = con.User.FirstOrDefault(b => b.IdUser == idUser);
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
                    con.User.Remove(User);
                    con.SaveChanges();
                    return "User deleted succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

<<<<<<< HEAD
        /// <summary>
        /// Verifies user data
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        public string TakeUserData(string email, string password)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var user = new User();
                    user = con.User.FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);

                    if (user == null)
                        return "Email or password incorrect.";
                    UserInfoStatic.UserName = user.UserName;
                    UserInfoStatic.UserSurname = user.UserSurname;
                    UserInfoStatic.UserRole = con.UserRoles.FirstOrDefault(r => r.IdUserRole == user.IdUserRole).UserRole;
                    return "Success";
                }

            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// List of all System users.
        /// </summary>
        public List<User> GetAllUsers()
        {
            var allUsers = new List<User>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    allUsers = con.User.ToList();

                }
            }
            catch (Exception ex)
            {

            }
            return allUsers;
        }

        /// <summary>
        /// List of all System users (boosted).
        /// </summary>
        public List<UserInfo> GetAllUsersInfo()
        {
            var allUsersInfo = new List<UserInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<User> allUsers = con.User.ToList();

                    if (allUsers.Count == 0)
                        return allUsersInfo;

                    for (int i = 0; i < allUsers.Count; i++)
                    {
                        UserInfo userInfo = new UserInfo();

                        userInfo.IdUser = allUsers[i].IdUser;
                        userInfo.UserName = allUsers[i].UserName;
                        userInfo.UserSurname = allUsers[i].UserSurname;
                        userInfo.UserEmail = allUsers[i].UserEmail;
                        userInfo.IdUserRole = allUsers[i].IdUserRole;
                        userInfo.UserPassword = allUsers[i].UserPassword;
                        userInfo.UserRole = con.UserRoles.FirstOrDefault(r => r.IdUserRole == userInfo.IdUserRole).UserRole;                        

                        allUsersInfo.Add(userInfo);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return allUsersInfo;       
        }
    }
}
