using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Entity
{
    class MenuInfo
    {
        private int menu_id;
        private string name;
        private float unit_price;
        private string category_name;

        public MenuInfo(string name, float unit_price, string category_name)
        {
            this.Name = name;
            this.UnitPrice = unit_price;
            this.CategoryName = category_name;
        }

        public int MenuId {get; set;}
        public string Name {get; set;}
        public float UnitPrice {get; set;}
        public string CategoryName {get; set;}
    }
}
