using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Entity;
using DataAccessLayer;
using System.Data;

namespace Admin.DataLayer
{
    class RegistrationDl
    {

        public void InsertUser(UserInfo userinfo)
        {

            DataAccess dataaccess = new DataAccess();


            //Console.WriteLine(userinfo.UserId + userinfo.Name + userinfo.Phone + userinfo.Gender + userinfo.Password + userinfo.UserType);
            dataaccess.QueryText(@"insert into tbl_user (user_id,name,user_name,phone,gender,password,user_type) " +
              "values (AUTO_ID.NEXTVAL,?,?,?,?,?,?)");



            //dataaccess.DbCommand.Parameters.AddWithValue("@user_id", "AUTO_ID.NEXTVAL");
            dataaccess.DbCommand.Parameters.AddWithValue("@name", userinfo.Name);
            dataaccess.DbCommand.Parameters.AddWithValue("@user_name", userinfo.UserName);
            dataaccess.DbCommand.Parameters.AddWithValue("@phone", userinfo.Phone);
            dataaccess.DbCommand.Parameters.AddWithValue("@gender", userinfo.Gender);
            dataaccess.DbCommand.Parameters.AddWithValue("@password", userinfo.Password);
            dataaccess.DbCommand.Parameters.AddWithValue("@user_type", userinfo.UserType);
            dataaccess.DbCommand.CommandType = CommandType.Text;
            dataaccess.DbCommand.ExecuteNonQuery();



        }
    }
}
