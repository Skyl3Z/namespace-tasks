using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        public static void Move()
        {
            Console.WriteLine("Player is moving");
        }

        public static void Attack()
        {
            Console.WriteLine("Player is attacking");
        }
    }
}

namespace Chat 
{
    internal class Player
    {
        public static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
