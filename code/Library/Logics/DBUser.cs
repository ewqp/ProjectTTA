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
                    UserInfoStatic.Name = user.Name;
                    UserInfoStatic.Surname = user.Surname;
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
        public List<EntityModel.User> GetAllUsers()
        {
            var allUsers = new List<EntityModel.User>();

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
        public List<Models.UserInfo> GetAllUsersInfo()
        {
            var allUsersInfo = new List<Models.UserInfo>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    List<EntityModel.User> allUsers = con.User.ToList();

                    if (allUsers.Count == 0)
                        return allUsersInfo;

                    for (int i = 0; i <= allUsers.Count; i++)
                    {
                        Models.UserInfo userInfo = new Models.UserInfo();

                        userInfo.IdUser = allUsers[i].IdUser;
                        userInfo.Name = allUsers[i].Name;
                        userInfo.Surname = allUsers[i].Surname;
                        userInfo.Email = allUsers[i].Email;
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
