using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_shop_billing
{
    class Pizza_Toppings
    {
        string toppingname;
        public string Toppingname
        {
            get { return toppingname; }
            set
            {
                toppingname = value;
            }
        }

        public float toppingprice()
        {
            float val = 0;
            foreach (KeyValuePair<string, float> item in Utils.pizza_toppings_price)
            {
                if (this.toppingname == item.Key)
                {
                    val = item.Value;
                }
            }
            return val;
        }
        public override string ToString()
        {
            return string.Format("Toppingname:{0}\ntoppingprice:{1}", this.toppingname, this.toppingprice());
        }
    }
}
