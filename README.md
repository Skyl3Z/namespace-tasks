Namespace Tasks (C# Console)

A small C# console project made to practice namespaces, using aliases, global namespace, and basic OOP structure with multiple mini tasks inside one solution.



📌 Project Overview

This project contains 10 tasks, each focused on a different namespaces/topic in C#:



✅ What you will learn here

using directives and importing namespaces

using alias = ... (namespace/type aliases)

Working with multiple namespaces that have the same class names

global:: keyword (global namespace qualifier)

Structuring code into folders like Models, Services, UI, etc.

A small Todo Console App as a final task



🧩 Tasks Included

Task 1 — Basic Models & Services

Create a User and use UserService to print/save info.

Task 2 — Logger Tool

Simple logging system:

Log()

Warn()

Error()

Task 3 — Namespaces with Same Class Name

Example: Chat.Player vs Game.Player

Task 4 — Type Aliases

Using aliases like:

using BankAcc = Bank.Account;
using GameAcc = Game.Account;

Task 5 — Nested Namespaces

Example:

Store.Products.Food.Bread

Store.Products.Electronics.Laptop

Task 6 — Conflicting Namespaces

Example:

A.B

Test.A.B

Task 7 — Global Namespace

Using:

global::System.Console.WriteLine(...)

Task 8 — Aliases for Services / Models / UI

Example:

using user = Models.User;
using menu = UI.Menu;

Task 9 — Calculator (Static Methods)

Basic math operations: Add, Sub, Mul, Div

Task 10 — Todo Console App

A simple menu-based Todo app:

Add task

Show all tasks

Complete task

Edit task

Remove task

Exit



🛠 Technologies Used

C#

.NET Console Application

Visual Studio




▶ How to Run

Open the solution in Visual Studio

Build the project

Run it (Ctrl + F5)



📁 Project Structure
namespace tasks/
  namespace tasks.slnx
  namespace tasks/
    namespace tasks.csproj
    Program.cs

    Task1.cs
    Task2.cs
    Task3.cs
    Task4.cs
    Task5.cs
    Task6.cs
    Task7.cs

    task8Models.cs
    task8Services.cs
    task8UI.cs

    Task9.cs

    Task10models.cs
    Task10Services.cs
    Task10UI.cs
    Task10Storage.cs



💡 Notes

This project is meant for learning and practice

Most tasks are executed directly inside Program.cs

Task 10 is the biggest part (interactive Todo system)



📌 Future Improvements (Optional)

Save todo tasks to a file (JSON / TXT)

Add task priorities and deadlines

Add input validation for empty task names

Separate each task into its own file/project
