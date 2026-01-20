using Company.Project.Tools;
using Models;
using MyMath.Core;
using Services;
using Store.Products.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Services;
using BankAcc = Bank.Account;
using GameAcc = Game.Account;
using menu = UI.Menu;
using product = Models.Product;
using productService = Services.ProductService;
using store = Store.Products;
using user = Models.User;
using userService = Services.UserService;






namespace namespace_tasks
{


    internal class Program
    {
        static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            
            //task 1 

            //User user1 = new User("Joe", 25);

            //UserService userService = new UserService();

            //userService.CreateUser(user1);
            //userService.PrintUser(user1);


            //task 2

            Logger.Log("User created and printed successfully.");
            Logger.Warn("This is a warning message.");
            Logger.Error("This is an error message.");


            //task 3

            Chat.Player.SendMessage("Hello World");
            Game.Player.Move();
            Game.Player.Attack();


            //task 4

            BankAcc bankAccount = new BankAcc();
            bankAccount.Deposit(1000);
            bankAccount.WithDraw(500);

            GameAcc gameAccount = new GameAcc();
            gameAccount.Login("username");
            gameAccount.ChangeSkin("skinname");


            //task 5

            store.Food.Bread bread = new store.Food.Bread();
            bread.GetPrice();
            bread.GetInfo();

            store.Electronics.Laptop laptop = new store.Electronics.Laptop();
            laptop.GetPrice();
            laptop.GetInfo();


            //task 6

            A.B f = new A.B();
            f.WhoAmI();

            Test.A.B g = new Test.A.B();
            g.WhoAmI();


            //task 7

            global::System.Console.WriteLine("Hello from the global namespace!");
            System.Console.WriteLine("Hello from the System namespace!");

            
            //task 8

            user us = new user();
            us.DisplayInfo();
            product pr = new product();
            pr.DisplayDetails();
            userService uss = new userService();
            uss.CreateUser(us);
            productService prs = new productService();
            prs.CreateProduct(pr);
            menu m = new menu();
            m.ShowMainMenu();


            //task 9
            
            Calculator calculator = new Calculator();
            int sum = Calculator.Add(5, 10);
            int sub = Calculator.Sub(10, 5);
            int mul = Calculator.Mul(5, 10);
            double div = Calculator.Div(10, 2);

            Console.WriteLine($"Sum: {sum}, Subtraction: {sub}, Multiplication: {mul}, Division: {div}");


            //task 10


            bool exit = false;
            TodoService service = new TodoService();

            while (!exit)
            {
                Console.Clear();

                TodoApp.UI.Menu.ShowMenu();

                char num = Console.ReadKey().KeyChar;
                Console.WriteLine();
                int parsedNum;
                int[] allowedChars = { 1, 2, 3, 4, 5, 6 };

                if (int.TryParse(num.ToString(), out parsedNum))
                {
                    if (allowedChars.Contains(parsedNum))
                    {
                        switch (parsedNum)
                        {
                            case 1:
                                Console.Write("Enter task text: ");
                                string text = Console.ReadLine();
                                service.AddTask(text);

                                Pause();

                                break;
                            case 2:
                                List<TodoItem> list = service.GetAllTasks();

                                if (list.Count == 0)
                                {
                                    Console.WriteLine("No tasks found.");

                                    Pause();

                                    break;
                                }

                                foreach (var item in list)
                                {
                                    Console.WriteLine(item.ToDisplayString());
                                }

                                Pause();

                                break;
                            case 3:
                                Console.Write("Enter task ID: ");
                                if (!int.TryParse(Console.ReadLine(), out int id))
                                {
                                    Console.WriteLine("Invalid ID format.");

                                    Pause();

                                    break;
                                }

                                service.CompleteTask(id);

                                Pause();

                                break;
                            case 4:
                                Console.Write("Enter task ID: ");
                                if (!int.TryParse(Console.ReadLine(), out int id1))
                                {
                                    Console.WriteLine("Invalid ID format.");

                                    Pause();

                                    break;
                                }

                                Console.Write("Enter new text: ");
                                string text1 = Console.ReadLine();

                                service.EditTask(id1, text1);

                                Pause();

                                break;
                            case 5:
                                Console.Write("Enter task ID: ");
                                if (!int.TryParse(Console.ReadLine(), out int id2))
                                {
                                    Console.WriteLine("Invalid ID format.");

                                    Pause();

                                    break;
                                }

                                service.RemoveTask(id2);

                                Pause(); 

                                break;
                            case 6:
                                exit = true;
                                break;
                        }
                    }
                }
            }

        }
    }
}
