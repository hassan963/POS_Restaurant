using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.DataLayer;
using Admin.Entity;
using System.Data;

namespace Admin.Repository
{
    class RegistrationRep
    {
        public string AddUser(UserInfo user)
        {

            //ADD USERS
            RegistrationDl regisDl = new RegistrationDl();

            string operationType = regisDl.InsertUser(user);
            return operationType;
        }

        public DataSet GetUsers()
        {
            //GRID VIEW POPULATE
            RegistrationDl regisDl = new RegistrationDl();
            DataSet ds = regisDl.GetUserList();
            return ds;
        }

        public string DeleteUser(string userName)
        {
            RegistrationDl regisDl = new RegistrationDl();
            string operationType = regisDl.DeleteUser(userName);
            return operationType;
        }

        public DataSet SearchUserType(string userType)
        {
            // calling method of datalayer SearchUserType(userType), stored in dataset
            RegistrationDl regisDl = new RegistrationDl();
            DataSet ds = regisDl.SearchUserType(userType);
            return ds;
        }
    }
}
