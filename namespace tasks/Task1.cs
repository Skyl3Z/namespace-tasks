//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Models
//{
//    public class User
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public User(string Name, int Age)
//        {
//            this.Name = Name;
//            this.Age = Age;
//        }

//    }
//}


//namespace Services 
//{
//    using Models;
//    public class UserService
//    {
//        static Dictionary<string, int> users = new Dictionary<string, int>();
//        public void CreateUser(User user)
//        {
//            if (users.ContainsKey(user.Name))
//            {
//                users[user.Name] = user.Age;
//            } else
//            {
//                users.Add(user.Name, user.Age);
//            }
//        }

//        public void PrintUser(User user)
//        {
//            if (users.ContainsKey(user.Name))
//            {
//                Console.WriteLine("User: " + user.Name + ", Age: " + users[user.Name]);
//            }
//            else
//            {
//                Console.WriteLine("User not found.");
//            }
//        }
//    }
//}
