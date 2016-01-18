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
        public string AddUser(string name, string surname, string email, int idUserRole, string userPassword)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var newUser = new User();
                    newUser.Name = name;
                    newUser.Surname = surname;
                    newUser.Email = email;
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

        public List<Models.UserAllInfo> GetAllUsersInfo()
        {
            var allUsersInfo = new List<Models.UserAllInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
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
                    con.SaveChanges();
                    return "User updated succesfully.";
                }
            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
        public string DeleteUser(int idUser)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var User = con.User.FirstOrDefault(b => b.IdUser == idUser);
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

        public string TakeUserData(string email, string password)
        {
            try
            {
                using (var con = new EntitiesLib())
                {
                    var user = new User();
                    user = con.User.FirstOrDefault(u => u.Email == email && u.UserPassword == password);

                    if (user == null)
                        return "Email or password incorrect.";
                    UserInfo.Name = user.Name;
                    UserInfo.Surname = user.Surname;
                    UserInfo.UserRole = con.UserRole.FirstOrDefault(r => r.IdUserRole == user.IdUserRole).UserRole1;
                    return "Success";
                }

            }
            catch (Exception exc)
            {
                return exc.Message;
            }
        }
    }
}
