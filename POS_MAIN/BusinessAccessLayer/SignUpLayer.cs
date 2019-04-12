using System;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class SignUpLayer
    {
        public Boolean RegisterUser(string user_id, string name, string phone, string gender, string passsword, string user_type)
        {
            DataAccess dataAccess = new DataAccess();
            User user = new User(user_id, name, phone, gender, passsword, user_type);
            dataAccess.Save(user);
            return true;
        }
    }
}
