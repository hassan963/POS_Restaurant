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
        public string AddMenu(MenuInfo menuInfo)
        {
            MenuInfoDl menuInfoDl = new MenuInfoDl();
            string operationType = menuInfoDl.InsertMenu(menuInfo);
            return operationType;
        }

        public DataSet GetMenu()
        {
            MenuInfoDl menuinfodl = new MenuInfoDl();
            DataSet ds = menuinfodl.GetMenuList();
            return ds;
        }

        public string DeleteMenu(string menuId)
        {
            MenuInfoDl menuInfoDl = new MenuInfoDl();
            string operationType = menuInfoDl.DeleteMenu(menuId);
            return operationType;
        }

        public DataSet SearchMenuName(string name)
        {
            MenuInfoDl menuInfoDl = new MenuInfoDl();
            DataSet ds = menuInfoDl.SearchMenu(name);
            return ds;
        }
    }
}
