using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserInfo
    {
        private string user_id;
        private string name;
        private string phone;
        private string gender;
        private string password;
        private string user_type;


        public UserInfo(string user_id, string name, string phone, string gender, string password, string user_type)
        {
            this.User_Id = user_id;
            this.Name = name;
            this.Phone = phone;
            this.Gender = gender;
            this.Password = password;
            this.User_Type = user_type;
        }

        public string User_Id
        {
            set { user_id = value; }
            get { return user_id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }
        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string User_Type
        {
            set { user_type = value; }
            get { return user_type; }
        }
    }
}
