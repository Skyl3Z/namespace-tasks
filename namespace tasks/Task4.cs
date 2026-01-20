using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Account
    {
        public void Deposit(int amount)
        {
            Console.WriteLine("Deposited: " + amount);
        }

        public void WithDraw(int amount)
        {
            Console.WriteLine("Withdrew: " + amount);
        }
    }
}


namespace Game 
{
    public class Account
    {
        public void Login(string username)
        {
            Console.WriteLine("User " + username + " logged in");
        }

        public void ChangeSkin(string skinName)
        {
            Console.WriteLine("Changed skin to: " + skinName);
        }
    }
}