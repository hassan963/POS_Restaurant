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
    class MenuInfoDl
    {
        DataSet Ds { get; set; }
        public string InsertMenu(MenuInfo menuinfo)
        {
            string operationType = "";
            DataAccess dataaccess = new DataAccess();
            string sql = "select * from tbl_menu where name = '"+menuinfo.Name+"'";
            Ds = dataaccess.ExecuteQuery(sql);

            /*Console.WriteLine(menuinfo.MenuId);
            Console.WriteLine(menuinfo.Name);
            Console.WriteLine(menuinfo.UnitPrice);
            Console.WriteLine(menuinfo.CategoryName);*/

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                sql = @"update tbl_menu
                set name = '" + menuinfo.Name + @"',
                unit_price = '" + menuinfo.UnitPrice + @"',
                category_name = '" + menuinfo.CategoryName + @"'
                where name = '" + menuinfo.Name + "'";

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
                dataaccess.InitiateProcedure("INSERT_INTO_MENU");
                dataaccess.DbCommand.Parameters.AddWithValue("name", "varchar2").Value = menuinfo.Name;
                dataaccess.DbCommand.Parameters.AddWithValue("unit_price", "FLOAT").Value = menuinfo.UnitPrice;
                dataaccess.DbCommand.Parameters.AddWithValue("category_name", "VARCHAR2").Value = menuinfo.CategoryName;

                dataaccess.DbCommand.ExecuteNonQuery();

                operationType = "Insert done";

                
            }
            return operationType;

        }

        public DataSet GetMenuList()
        {
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery("select * from tbl_menu");
            return ds;
        }


    }
}
