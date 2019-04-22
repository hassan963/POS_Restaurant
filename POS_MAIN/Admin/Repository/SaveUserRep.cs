using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.DataLayer;
using Admin.EntityLayer;

namespace Admin.Repository
{
    class SaveUserRep
    {
        public void InsertUser(UserInfo userInfo)
        {
            SaveUserDL saveUserDL = new SaveUserDL();
            saveUserDL.Save(userInfo);
        }
    }
}
