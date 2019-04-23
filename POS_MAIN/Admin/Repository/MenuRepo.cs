using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Entity;
using Admin.DataLayer;
using System.Data;

namespace Admin.Repository
{
    class MenuRepo
    {
        public string AddMenu(MenuInfo menuinfo)
        {
            MenuInfoDl menuinfodl = new MenuInfoDl();
            string operationType = menuinfodl.InsertMenu(menuinfo);
            return operationType;
        }

        public DataSet GetMenu()
        {
            MenuInfoDl menuinfodl = new MenuInfoDl();
            DataSet ds = menuinfodl.GetMenuList();
            return ds;
        }
    }
}
