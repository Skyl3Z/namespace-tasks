using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class UserService
    {
        public void CreateUser(Models.User user)
        {
            Console.WriteLine("User created: " + user.ToString());
        }
        public void PrintUser(Models.User user)
        {
            user.DisplayInfo();
        }
    }

    internal class ProductService
    {
        public void CreateProduct(Models.Product product)
        {
            Console.WriteLine("Product created: " + product.ToString());
        }
        public void PrintProduct(Models.Product product)
        {
            product.DisplayDetails();
        }
    }
}
