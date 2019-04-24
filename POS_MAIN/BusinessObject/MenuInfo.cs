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
        private string category_name;

        public MenuInfo(string name, float unit_price, string category_name)
        {
            this.Name = name;
            this.UnitPrice = unit_price;
            this.Category_Name = category_name;
        }
        public MenuInfo(int menu_id, string name, float unit_price, string category_name)
        {
            this.Name = name;
            this.UnitPrice = unit_price;
            this.Category_Name = category_name;
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
        public string Category_Name
        {
            set { category_name = value; }
            get { return category_name; }
        }
        public int Menu_Id
        {
            set { menu_id = value; }
            get { return menu_id; }
        }
    }
}
