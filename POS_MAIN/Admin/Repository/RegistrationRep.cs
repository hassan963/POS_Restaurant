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
            RegistrationDl regisdl = new RegistrationDl();

            string operationType = regisdl.InsertUser(user);
            return operationType;
        }

        public DataSet GetUsers()
        {
            RegistrationDl regisdl = new RegistrationDl();
            DataSet ds = regisdl.GetUserList();
            return ds;
        }
    }
}
