using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class User
    {
        private string user_id;
        private string name;
        private string phone;
        private string gender;
        private string passsword;
        private string user_type;

        public User(string user_id, string name, string phone, string gender, string passsword, string user_type)
        {
            User_Id = user_id;
            Name = name;
            Phone = phone;
            Password = passsword;
            User_Type = user_type;
            Gender = gender;
        }

        public string User_Id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Password
        {
            get { return passsword; }
            set { passsword = value; }
        }
        public string User_Type
        {
            get { return user_type; }
            set { user_type = value; }
        }


    }
}
