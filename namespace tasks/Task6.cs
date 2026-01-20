using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class B
    {
        public void WhoAmI()
        {
            Console.WriteLine("I am A.B");
        }
    }
}

namespace Test 
{
    internal class A
    {
        public class B
        {
            public void WhoAmI()
            {
                Console.WriteLine("I am Test.A.B");
            }
        }
    }
}