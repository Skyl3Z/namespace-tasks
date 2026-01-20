using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TodoApp.Models
{
    internal class TodoItem
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public bool IsDone { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? CompletedAt { get; private set; }

        public void MarkAsDone()
        {
            IsDone = true;
            CompletedAt = DateTime.Now;
        }

        public void MarkAsUndone()
        {
            IsDone = false;
            CompletedAt = null;

        }

        public TodoItem(int id, string text)
        {
            this.Id = id;
            this.Text = text;
            IsDone = false;
            CreatedAt = DateTime.Now;
            CompletedAt = null;

        }

        public void EditText(string text)
        {
            this.Text = text;
        }

        public string ToDisplayString()
        {
            string status = IsDone ? "[X]" : "[ ]";
            string created = CreatedAt.ToString("dd.MM HH:mm");
            string done = CompletedAt?.ToString("dd.MM HH:mm") ?? "-";

            return $"{Id}) {status} {Text} | Created: {created} | Done: {done}";
        }
    }
}
