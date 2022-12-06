using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_shop_billing
{
    class Bill
    {
        Pizza_Confromation confromation;
        List<Pizza_Flavor> flavors=new List<Pizza_Flavor>(2);
        List<Pizza_Toppings> toppings=new List<Pizza_Toppings>(4);
        float total=0;

        public Pizza_Confromation Confromation
        {
            get { return confromation; }
            set
            {
                confromation = value;
            }
        }
        public List<Pizza_Flavor> Flavors
        {
            get { return flavors; }
            set
            {
                flavors = value;
            }
        }
        public List<Pizza_Toppings> Toppings
        {
            get { return toppings; }
            set
            {
                toppings = value;
            }
        }
        public override string ToString()
        {
            string x = "";
            this.total += this.confromation.size_price() + this.confromation.base_price();
            x += this.confromation.ToString();
            x += "\n";
            foreach (Pizza_Flavor item in this.flavors)
            {
                this.total += item.flavourprice();
                x += item.ToString();
                x += "\n";
            }
            foreach (Pizza_Toppings item in this.toppings)
            {
                this.total += item.toppingprice();
                x += item.ToString();
                x += "\n";
            }
            x += "Total Amount"+this.total;
            return x;
        }
    }
}
