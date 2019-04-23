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
        DataSet Ds { get; set; }
        public string InsertUser(UserInfo userinfo)
        {

            DataAccess dataaccess = new DataAccess();

            string operationType = "";
            string sql = "select * from tbl_user where name = '" + userinfo.Name + "'";
            Ds = dataaccess.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update tbl_user 
                set name = '"+userinfo.Name+@"',
                user_name = '"+userinfo.UserName+@"',
                phone = '"+userinfo.Phone+@"',
                gender = '"+userinfo.Gender+@"',
                password = '"+userinfo.Password+@"',
                user_type = '"+userinfo.UserType+@"'
                where name = '"+userinfo.Name+"'";

                try
                {
                    dataaccess.ExecuteUpdateQuery(sql);
                    operationType = "Update Done";
                }

                catch (Exception exc)
                {
                    Console.Write(exc);
                }
            }
            else
            {

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

                operationType = "Insert Done";
            }

            return operationType;

        }

        public DataSet GetUserList()
        {
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery("select * from tbl_user");
            return ds;  
        }
    }
}
