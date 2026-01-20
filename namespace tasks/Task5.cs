using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products.Food
{
    public class Bread
    {
        public string name = "bread";
        public int price = 2;

        public void GetInfo()
        {
            Console.WriteLine("Product: " + name + ", Price: " + price + "$");
        }

        public void GetPrice()
        {
            Console.WriteLine("price:" + price);
        }
    }

    public class Milk
    {
        public string name = "milk";
        public int price = 5;

        public void GetInfo()
        {
            Console.WriteLine("Product: " + name + ", Price: " + price + "$");
        }

        public void GetPrice()
        {
            Console.WriteLine("price:" + price);
        }
    }

    
}


namespace Store.Products.Electronics 
{
    public class Laptop
    {
        public string name = "Laptop";
        public int price = 2000;

        public void GetInfo()
        {
            Console.WriteLine("Product: " + name + ", Price: " + price + "$");
        }

        public void GetPrice()
        {
            Console.WriteLine("price:" + price);
        }
    }

    public class Phone
    {
        public string name = "Phone";
        public int price = 1000;

        public void GetInfo()
        {
            Console.WriteLine("Product: " + name + ", Price: " + price + "$");
        }

        public void GetPrice()
        {
            Console.WriteLine("price:" + price);
        }
    }
}