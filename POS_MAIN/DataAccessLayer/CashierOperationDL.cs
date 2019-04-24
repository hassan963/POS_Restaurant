using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using System.Data.OleDb;

namespace DataAccessLayer
{
    public class CashierOperationDL
    {
        

        public CashierOperationDL()
        {
            Data_Access = new DataAccess();
        }

        private DataAccess Data_Access
        {
            set;
            get;
        }

        public List<MenuInfo> GetMenus(string name)
        {
            List<MenuInfo> menuList = new List<MenuInfo>();
            menuList.Clear();
           // DataAccess dataAccess = new DataAccess();
            DataSet ds = Data_Access.ExecuteQuery("select * from tbl_menu where category_name like '"+ name +"'");

           int count =  ds.Tables[0].Rows.Count;

            for (int i = 0; i< count; i++)
            {
                menuList.Add(new MenuInfo(int.Parse(ds.Tables[0].Rows[i][0].ToString()), ds.Tables[0].Rows[i][1].ToString(), float.Parse(ds.Tables[0].Rows[i][2].ToString()), ds.Tables[0].Rows[i][3].ToString()));
            }

            return menuList;

        }

        public Boolean InsertIntoOrder(OrderDetailsRepo orderDetailsRepo, string user_name, string status)
        {
            //UNIT_PRICE   QUANTITY  MENU_ID  USER_ID  STATUS 
            //  DataAccess dataAccess = new DataAccess();
            Data_Access.InitiateProcedure("INSERT_INTO_ORDER");
            Data_Access.DbCommand.Parameters.AddWithValue("ORDER_ID", "varchar2").Value = orderDetailsRepo.Order_Id;
            Data_Access.DbCommand.Parameters.AddWithValue("UNIT_PRICE", "FLOAT").Value = orderDetailsRepo.Unit_Price;
            Data_Access.DbCommand.Parameters.AddWithValue("QUANTITY", "NUMBER").Value = orderDetailsRepo.Quantity;
            Data_Access.DbCommand.Parameters.AddWithValue("MENU_ID", "NUMBER").Value = orderDetailsRepo.Menu_Id;
            Data_Access.DbCommand.Parameters.AddWithValue("USER_NAME", "VARCHAR2").Value = user_name;
            Data_Access.DbCommand.Parameters.AddWithValue("STATUS", "VARCHAR2").Value = status;
            Data_Access.DbCommand.ExecuteNonQuery();
            return true;
        }


        public List<MenuInfo> SearchMenuByIdOrName(string search_text)
        {
           // DataAccess dataAccess = new DataAccess();

            List<MenuInfo> menuList = new List<MenuInfo>();
            menuList.Clear();

            string sql = "select * from tbl_menu where name like '" + search_text + "%' or menu_id like '" + search_text + "%'";

            DataSet dataSet = Data_Access.ExecuteQuery(sql);

            int count = dataSet.Tables[0].Rows.Count;

            for (int i = 0; i < count; i++)
            {
                menuList.Add(new MenuInfo(int.Parse(dataSet.Tables[0].Rows[i][0].ToString()), dataSet.Tables[0].Rows[i][1].ToString(), float.Parse(dataSet.Tables[0].Rows[i][2].ToString()), dataSet.Tables[0].Rows[i][3].ToString()));
            }
            return menuList;
          
        }

        public DataSet GetOrderDetails(string order_id)
        {
            string sql = "select * from tbl_order_details where order_id like '" + order_id + "'";
            return Data_Access.ExecuteQuery(sql);
           
        }

        public DataSet GetOrderStatus(string order_id)
        {
            string sql = "select * from tbl_order where order_id like '" + order_id + "'";
            return Data_Access.ExecuteQuery(sql);
        }

    }
}
