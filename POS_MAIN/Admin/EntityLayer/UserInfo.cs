using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.EntityLayer
{
    class UserInfo
    {

        private string user_id;
        private string name;
        private string phone;
        private string gender;
        private string password;
        private string user_type;
        private string user_name;


        public UserInfo(string user_id, string name, string user_name, string phone, string gender, string password, string user_type)
        {
            this.User_Id = user_id;
            this.Name = name;
            this.Phone = phone;
            this.Gender = gender;
            this.Password = password;
            this.User_Type = user_type;
            this.User_Name = user_name;
        }

        public string User_Id
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }

        public string User_Name
        {
            set;
            get;
        }

        public string Phone
        {
            set;
            get;
        }
        public string Gender
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }
        public string User_Type
        {
            set;
            get;
        }


    }
}
