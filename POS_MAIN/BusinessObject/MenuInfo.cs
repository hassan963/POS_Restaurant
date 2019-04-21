using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MenuInfo
    {
        private int menu_id;
        private string name;
        private float unit_price;
        private int category_id;

        public MenuInfo(string name, float unit_price, int category_id)
        {
            this.Name = name;
            this.UnitPrice = unit_price;
            this.Category_id = category_id;
        }
        public MenuInfo(int menu_id, string name, float unit_price, int category_id)
        {
            this.Name = name;
            this.UnitPrice = unit_price;
            this.Category_id = category_id;
            this.Menu_Id = menu_id;

        }


        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public float UnitPrice
        {
            set { unit_price = value; }
            get { return unit_price; }
        }
        public int Category_id
        {
            set { category_id = value; }
            get { return category_id; }
        }
        public int Menu_Id
        {
            set { menu_id = value; }
            get { return menu_id; }
        }
    }
}
