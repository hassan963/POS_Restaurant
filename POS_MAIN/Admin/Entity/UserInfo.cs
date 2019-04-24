using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Entity
{
    class UserInfo
    {
        private int userid;
        private string name;
        private string username;
        private string phone;
        private string gender;
        private string password;
        private string usertype;

        public UserInfo(  string name, string username, string phone, string gender, string password, string usertype)
        {
            //this.UserId = userid;
            this.Name = name;
            this.UserName = username;
            this.Phone = phone;
            this.Gender = gender;
            this.Password = password;
            this.UserType = usertype;
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        /*public string Password
        {
            get { return this.password; }
            set
            {
                if (this.password.Length >= 4)
                    this.password = true;
                else
                    this.password = false;
            }
        }*/
        public string UserType { get; set; }
    }


}
