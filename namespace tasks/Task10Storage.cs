using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TodoApp.Models;

namespace TodoApp.Storage
{
    internal class TodoStorage
    {
        private List<TodoItem> savedTasks = new List<TodoItem>();

        public List<TodoItem> Load()
        {
            // возвращаем копию, чтобы никто не ломал внутренний список напрямую
            return new List<TodoItem>(savedTasks);
        }

        public void Save(List<TodoItem> tasks)
        {
            // сохраняем копию
            savedTasks = new List<TodoItem>(tasks);
        }
    }
}
