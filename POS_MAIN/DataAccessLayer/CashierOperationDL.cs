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
        }

        public List<MenuInfo> GetMenus(short id)
        {
            List<MenuInfo> menuList = new List<MenuInfo>();
            menuList.Clear();
            DataAccess dataAccess = new DataAccess();
            DataSet ds = dataAccess.ExecuteQuery("select * from tbl_menu where category_id = '"+ id +"'");

           int count =  ds.Tables[0].Rows.Count;

            for (int i = 0; i< count; i++)
            {
                menuList.Add(new MenuInfo(int.Parse(ds.Tables[0].Rows[i][0].ToString()), ds.Tables[0].Rows[i][1].ToString(), float.Parse(ds.Tables[0].Rows[i][2].ToString()), int.Parse(ds.Tables[0].Rows[i][3].ToString())));
            }

            return menuList;

        }

        public Boolean InsertIntoOrder(OrderDetailsRepo orderDetailsRepo, string user_id, string status)
        {
            //UNIT_PRICE   QUANTITY  MENU_ID  USER_ID  STATUS 
            DataAccess dataAccess = new DataAccess();
            dataAccess.InitiateProcedure("INSERT_INTO_ORDER");
            dataAccess.DbCommand.Parameters.AddWithValue("ORDER_ID", "varchar2").Value = orderDetailsRepo.Order_Id;
            dataAccess.DbCommand.Parameters.AddWithValue("UNIT_PRICE", "FLOAT").Value = orderDetailsRepo.Unit_Price;
            dataAccess.DbCommand.Parameters.AddWithValue("QUANTITY", "NUMBER").Value = orderDetailsRepo.Quantity;
            dataAccess.DbCommand.Parameters.AddWithValue("MENU_ID", "NUMBER").Value = orderDetailsRepo.Menu_Id;
            dataAccess.DbCommand.Parameters.AddWithValue("USER_ID", "VARCHAR2").Value = user_id;
            dataAccess.DbCommand.Parameters.AddWithValue("STATUS", "VARCHAR2").Value = status;
            dataAccess.DbCommand.ExecuteNonQuery();
            return true;
        }
    }
}
