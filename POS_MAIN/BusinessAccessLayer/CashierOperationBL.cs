using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessObject;
using System.Data;

namespace BusinessAccessLayer
{
    public class CashierOperationBL
    {
        

        public CashierOperationBL()
        {
            CashierOperation = new CashierOperationDL();
        }

        private CashierOperationDL CashierOperation
        {
            set;
            get;
        }

        public List<MenuInfo> GetList(string categoryName)
        {
            return CashierOperation.GetMenus(categoryName);
        }

        public Boolean Addorder(List<OrderDetailsRepo> orderDetailsRepoList, string user_name)
        {
            string status = "Processing";
           // CashierOperationDL cashierOperationDL = new CashierOperationDL();

            for(int i = 0; i < orderDetailsRepoList.Count; i++)
            {
                if (orderDetailsRepoList.Count - 1 == i) status = "DONE";
                CashierOperation.InsertIntoOrder(orderDetailsRepoList[i], user_name, status);
            }

            return true;
        }

        // Generate a random string with a given current date time  
        public string RandomString()
        {
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyyMMddhhmmss");
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 4; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString().ToLower()+"_"+formattedTime;
        }

        public List<MenuInfo> SearchMenus(string search_text)
        {
           // CashierOperationDL cashierOperationDL = new CashierOperationDL();
            return CashierOperation.SearchMenuByIdOrName(search_text);
        }

        public string GetDate()
        {
            var time = DateTime.Now;
            return "Date: " + time.ToString("dd/MM/yyyy");
        }

       public DataSet OrderDetails(string order_id)
       {
            return CashierOperation.GetOrderDetails(order_id);
       }

       public DataSet OrderStatus(string order_id)
        {
            return CashierOperation.GetOrderStatus(order_id);
        }
        
    }
}


