using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.DataLayer;
using Admin.Entity;

namespace Admin.Repository
{
    class RegistrationRep
    {
        public void AddUser(UserInfo user)
        {
            RegistrationDl regisdl = new RegistrationDl();

            regisdl.InsertUser(user);
        }
    }
}
