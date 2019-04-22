using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.EntityLayer;
using DataAccessLayer;
using System.Data.OleDb;
using System.Data;

namespace Admin.DataLayer
{
    class SaveUserDL
    {


        public void Save(UserInfo user)
        {
            DataAccess dataAccess = new DataAccess();
            Console.WriteLine(user.User_Id + user.Name + user.Phone + user.Gender + user.Password + user.User_Type);
            dataAccess.QueryText(@"insert into tbl_user (user_id,name,user_name,phone,gender,password,user_type) " +
              "values (?,?,?,?,?,?,?)");

            dataAccess.DbCommand.Parameters.AddWithValue("@user_id", user.User_Id);
            dataAccess.DbCommand.Parameters.AddWithValue("@name", user.Name);
            dataAccess.DbCommand.Parameters.AddWithValue("@name", user.User_Name);
            dataAccess.DbCommand.Parameters.AddWithValue("@phone", user.Phone);
            dataAccess.DbCommand.Parameters.AddWithValue("@gender", user.Gender);
            dataAccess.DbCommand.Parameters.AddWithValue("@password", user.Password);
            dataAccess.DbCommand.Parameters.AddWithValue("@user_type", user.User_Type);
            dataAccess.DbCommand.CommandType = CommandType.Text;
            dataAccess..ExecuteNonQuery();

            /*
             When excuting this query it will also trigger USER_AFTER_INSERT that will insert login 
             credentials to tbl_login table
             */

        }


    }
}
