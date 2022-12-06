using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_shop_billing
{
    class Pizza_Flavor
    {
        string flavourname;
       

        public string Flavourname
        {
            get { return flavourname; }
            set
            {
                flavourname = value;
            }
        }

        public float flavourprice()
        {
            float val = 0;
            foreach (KeyValuePair<string,float> item in Utils.pizza_flavours_price)
            {
                if (this.flavourname==item.Key)
                {
                    val = item.Value;
                }
            }
            return val;
        }
        public override string ToString()
        {
            return string.Format("Flavourname:{0}\nFlavourprice:{1}", this.flavourname, this.flavourprice());
        }
    }
}
