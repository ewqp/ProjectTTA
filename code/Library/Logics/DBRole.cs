using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.EntityModel;

namespace Library.Logics
{
    public class DBRole
    {
        /// <summary>
        /// List of all book genres in DB.
        /// </summary>
        public List<EntityModel.UserRole> GetAllUserRoles()
        {
            var userRoles = new List<EntityModel.UserRole>();

            try
            {
                using (var con = new EntitiesLib())
                {
                    userRoles = con.UserRole.ToList();
                }
            }
            catch (Exception ex)
            {

            }

            return userRoles;
        }
    }
}
