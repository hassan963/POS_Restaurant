using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using BusinessObject;

namespace DataAccessLayer
{
    public class DataAccess
    {
        private OleDbConnection oleDbConnection;
        public OleDbConnection DbConnection
        {
            get { return oleDbConnection; }
            set { oleDbConnection = value; }
        }

        private OleDbCommand oleDbCommand;
        public OleDbCommand DbCommand
        {
            get { return oleDbCommand; }
            set { oleDbCommand = value; }
        }

        private OleDbDataAdapter oleDbDataAdapter;
        public OleDbDataAdapter DbDataAdapter
        {
            get { return oleDbDataAdapter; }
            set { oleDbDataAdapter = value; }
        }

        private DataSet data;
        public DataSet DataSets
        {
            get { return data; }
            set { data = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            //Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;
            this.DbConnection = new OleDbConnection(@"Provider = MSDAORA; Data Source = localhost; User ID = hassan; Password = hassan; Unicode = True");
            DbConnection.Open();
        }

        public void QueryText(string query)
        {
            this.DbCommand = new OleDbCommand(query, this.DbConnection);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.DbDataAdapter = new OleDbDataAdapter(this.DbCommand);
            this.DataSets = new DataSet();
            this.DbDataAdapter.Fill(this.DataSets);
            return DataSets;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.DbCommand.ExecuteNonQuery();
            return u;
        }

        public void InitiateProcedure(string procedureName)
        {
            this.QueryText(procedureName);
            this.DbCommand.CommandType = CommandType.StoredProcedure;
            //this.DbCommand.ExecuteNonQuery();
        }

        public void Save(UserInfo user)
        {
            Console.WriteLine(user.User_Id + user.Name + user.Phone + user.Gender + user.Password + user.User_Type);
            this.QueryText(@"insert into tbl_user (user_id,name,phone,gender,password,user_type) " +
              "values (?,?,?,?,?,?)");
    
              DbCommand.Parameters.AddWithValue("@user_id", user.User_Id);
              DbCommand.Parameters.AddWithValue("@name", user.Name);
              DbCommand.Parameters.AddWithValue("@phone", user.Phone);
              DbCommand.Parameters.AddWithValue("@gender", user.Gender);
              DbCommand.Parameters.AddWithValue("@password", user.Password);
              DbCommand.Parameters.AddWithValue("@user_type", user.User_Type);
              DbCommand.CommandType = CommandType.Text;
              DbCommand.ExecuteNonQuery();

            /*
             When excuting this query it will also trigger USER_AFTER_INSERT that will insert login 
             credentials to tbl_login table
             */

        }
    }
}
