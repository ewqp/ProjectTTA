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
        /// <summary>
        /// Adding new user
        /// </summary>
        public string AddUser(string name, string surname, string email, int idUserRole, string userPassword)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newUser = new User();
                    newUser.UserName = name;
                    newUser.UserSurname = surname;
                    newUser.UserEmail = email;
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

        /// <summary>
        /// Edit user in User
        /// </summary>
        public string UpdateUser(int idUser, string name, string surname, string email, int idRole, string password)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var user = con.User.FirstOrDefault(u => u.IdUser == idUser);
                    user.UserName = name;
                    user.UserSurname = surname;
                    user.UserEmail = email;                    
                    user.IdUserRole = idRole;
                    user.UserPassword = password;
                    con.SaveChanges();
                    return "User updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }

        /// <summary>
        /// Delete user from User
        /// </summary>
        public string DeleteUser(int idUser)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var User = con.User.FirstOrDefault(u => u.IdUser == idUser);
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

        /// <summary>
        /// Verifies user data
        /// </summary>
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
