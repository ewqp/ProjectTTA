using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBUserRoles
    {
        /// <summary>
        /// List of User Roles
        /// </summary>
        public List<EntityModel.UserRoles> GetAllUserRoles()
        {
            var userRoles = new List<EntityModel.UserRoles>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    userRoles = con.UserRoles.ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return userRoles;
        }
    }
}
