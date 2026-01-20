using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;


namespace TodoApp.Services
{
    internal class TodoService
    {
        private int nextId = 1;
        private List<TodoItem> tasks = new List<TodoItem>();

        public void AddTask(string taskText)
        {
            if (string.IsNullOrWhiteSpace(taskText))
            {
                Console.WriteLine("Task text cannot be empty");
                return;
            }

            if (taskText.Length > 200)
            {
                Console.WriteLine("Task text cannot exceed 200 characters");
                return;
            }

            var task = new TodoItem(nextId, taskText);
            nextId++;

            tasks.Add(task);
        }

        public List<TodoItem> GetAllTasks()
        {
            return tasks;
        }

        public bool CompleteTask(int taskId)
        {
            if (taskId <= 0)
            {
                Console.WriteLine("Invalid task ID");
                return false;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                TodoItem item = tasks[i];

                if (item.Id == taskId)
                {
                    item.MarkAsDone();
                    return true;
                }
            }
            return false;
        }

        public bool RemoveTask(int taskId)
        {
            if (taskId <= 0)
            {
                Console.WriteLine("Invalid task ID");
                return false;
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                TodoItem item = tasks[i];
                if (item.Id == taskId)
                {
                    tasks.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool EditTask(int taskId, string newText)
        {
            if (taskId <= 0)
            {
                Console.WriteLine("invalid Id");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newText))
            {
                Console.WriteLine("Task text cannot be empty");
                return false;
            }

            if (newText.Length > 200)
            {
                Console.WriteLine("Task text cannot exceed 200 characters");
                return false;
            }

            for (int i =0; i < tasks.Count;i++)
            {
                TodoItem task = tasks[i];

                if (task.Id == taskId)
                {
                    task.EditText(newText);
                    return true;
                }
            }

            return false;
        }
    }
}
