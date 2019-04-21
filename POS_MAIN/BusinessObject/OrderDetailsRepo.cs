using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailsRepo
    {
        private string order_id;
        private float unit_price;
        private short quantity;
        private int menu_id;

        public OrderDetailsRepo(string order_id, float unit_price, short quantity, int menu_id)
        {
            this.Order_Id = order_id;
            this.Unit_Price = unit_price;
            this.Quantity = quantity;
            this.Menu_Id = menu_id;
        }

        public string Order_Id
        {
            set;
            get;
        }
        public float Unit_Price
        {
            set;
            get;
        }
        public short Quantity
        {
            set;
            get;
        }
        public int Menu_Id
        {
            set;
            get;
        }
    }
}
