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
