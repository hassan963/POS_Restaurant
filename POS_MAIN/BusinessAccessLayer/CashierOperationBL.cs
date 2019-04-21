using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessObject;

namespace BusinessAccessLayer
{
    public class CashierOperationBL
    {
        public List<MenuInfo> GetList(string categoryName)
        {
            short categoryID = 1;
            switch (categoryName)
            {
                case "BreakFast":
                    categoryID = 1;
                    break;
                case "SetMeals":
                    categoryID = 2;
                    break;
                case "Sandwich":
                    categoryID = 3;
                    break;
                case "Burger":
                    categoryID = 4;
                    break;
                case "Pizza":
                    categoryID = 5;
                    break;
                case "Starter":
                    categoryID = 6;
                    break;
                case "Pasta":
                    categoryID = 7;
                    break;
                case "Coffee":
                    categoryID = 8;
                    break;
                case "Drinks":
                    categoryID = 9;
                    break;
                case "Dessert":
                    categoryID = 10;
                    break;
                
            }
            return new CashierOperationDL().GetMenus(categoryID);
        }

        public Boolean Addorder(List<OrderDetailsRepo> orderDetailsRepoList, string user_id)
        {
            string status = "Processing";
            CashierOperationDL cashierOperationDL = new CashierOperationDL();

            for(int i = 0; i < orderDetailsRepoList.Count; i++)
            {
                if (orderDetailsRepoList.Count - 1 == i) status = "DONE";
                cashierOperationDL.InsertIntoOrder(orderDetailsRepoList[i], user_id, status);
            }

            return true;
        }
    }
}
