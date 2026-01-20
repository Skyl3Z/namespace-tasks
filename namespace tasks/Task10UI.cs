using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.UI
{
    internal class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("=== Todo Application Menu ===");
            Console.WriteLine("1. Add Todo task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Complete task");
            Console.WriteLine("4. Edit task");
            Console.WriteLine("5. Remove task");
            Console.WriteLine("6. Exit");
            Console.WriteLine("=============================");

        }
    }
}
