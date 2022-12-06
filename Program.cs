using System;

namespace Pizza_shop_billing
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Load_dictionary();
            Pizza_Confromation pizza = new Pizza_Confromation();
            Pizza_Flavor pizza_Flavor = new Pizza_Flavor();
            Pizza_Toppings pizza_Toppings = new Pizza_Toppings();
            Bill bill = new Bill();
            //Console.WriteLine("Enter the pizza size:{small,large,extralarge}");
            string size = "large";//Console.ReadLine().ToLower();
            
                if (Enum.IsDefined(typeof(Pizza_Size),size))
                {
                    Pizza_Size temp = (Pizza_Size)Enum.Parse(typeof(Pizza_Size), size);
                    pizza.Size = temp;
                }
                else
                {
                    Console.WriteLine("This size is not in pizza");
                }
            
            // Console.WriteLine("Enter the pizza base:{thin,thick,regular}");

            string Base = "thick";//Console.ReadLine().ToLower();
           
                if (Enum.IsDefined(typeof(Pizza_Base), Base))
                {
                    Pizza_Base temp = (Pizza_Base)Enum.Parse(typeof(Pizza_Base), Base);
                    pizza.Base = temp;
                }
                else
                {
                    Console.WriteLine("This base is not in pizza");
                }
           
            pizza_Flavor.Flavourname = "Barbeque chicken";
           
            bill.Flavors.Add(pizza_Flavor);
            pizza_Flavor.Flavourname = "Pepperoni";
           // pizza_Flavor.flavourprice();
            bill.Flavors.Add(pizza_Flavor);
            pizza_Toppings.Toppingname = "Fried chicken";
            //pizza_Toppings.toppingprice();
            bill.Toppings.Add(pizza_Toppings);
            pizza_Toppings.Toppingname = "Spicy chicken";
           
            bill.Toppings.Add(pizza_Toppings);
            bill.Confromation = pizza;
            Console.WriteLine(bill);

        }
    }
}
