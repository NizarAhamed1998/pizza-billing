using System;
using System.Collections.Generic;
using System.IO;

namespace Pizza_shop_billing
{
    class Utils
    {
        public static Dictionary<string, float> pizza_structure_price = new Dictionary<string, float>();
        public static Dictionary<string, float> pizza_flavours_price = new Dictionary<string, float>();
        public static Dictionary<string, float> pizza_toppings_price = new Dictionary<string, float>();
        public static void Load_dictionary_topping()
        {
            string filepath = @"E:\Database\pizza_topping_price.txt";
            string[] fileitems = File.ReadAllLines(filepath);
            foreach (string item in fileitems)
            {
                string[] item_values = item.Split('=');
                pizza_toppings_price.Add(item_values[0], Convert.ToSingle(item_values[1]));
            }
        }
        public static void Load_dictionary_flavour()
        {
            string filepath = @"E:\Database\pizza_flavour_price.txt";
            string[] fileitems = File.ReadAllLines(filepath);
            foreach (string item in fileitems)
            {
                string[] item_values = item.Split('=');
                pizza_flavours_price.Add(item_values[0], Convert.ToSingle(item_values[1]));
            }
        }
        public static void Load_dictionary_structure()
        {

            string filepath = @"E:\Database\pizza_structure_price.txt";
            string[] fileitems = File.ReadAllLines(filepath);
            foreach (string item in fileitems)
            {
                string[] item_values = item.Split(',');
                pizza_structure_price.Add(item_values[0], Convert.ToSingle(item_values[1]));
            }
        }
        public static void Load_dictionary()
        {
            Load_dictionary_flavour();
            Load_dictionary_topping();
            Load_dictionary_structure();
        }
    }
}
