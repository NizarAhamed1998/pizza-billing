using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_shop_billing
{
    class Pizza_Confromation
    {
        Pizza_Size _size;
        Pizza_Base _base;
       
        public Pizza_Size Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        public Pizza_Base Base
        {
            get { return _base; }
            set
            {
                _base = value;
            }
        }
       
        public float size_price()
        {
            float val = 0;
            foreach (KeyValuePair<string,float> item in Utils.pizza_structure_price)
            {
                if (this._size.ToString()==item.Key.ToLower())
                {
                    val = item.Value;
                }
            }
            return val;
        }
        public float base_price()
        {
            float val = 0;
            foreach (KeyValuePair<string, float> item in Utils.pizza_structure_price)
            {
                if (this._base.ToString() == item.Key.ToLower())
                {
                    val = item.Value;
                }
            }
            return val;
        }
        public override string ToString()
        {
            return string.Format("Size:{0}\nBase:{1}\nSizePrice:{2}\nBasePrice:{3}", this._size, this._base, this.size_price(), this.base_price());
        }
    }
    public enum Pizza_Size
    {
        small,
        large,
        extralarge
    }
    public enum Pizza_Base
    {
        thin,
        thick,
        regular
    }
   
}
