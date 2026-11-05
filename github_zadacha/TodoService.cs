using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class TodoService
    {
        private readonly List<TodoItem> todos = new List<TodoItem>();
        private static int nextId = 1;

        public List<TodoItem> GetAll()
        { 
           return todos;
        }

        public void Add(string title,string description,DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);
            todos.Add(todoItem);
            nextId++;
        }

        public TodoItem FindById(int id)
        {
            foreach (TodoItem todo in todos)
            {
                if (todo.Id == id)
                {
                    return todo;
                }
            }

            return null;
        }

        public void Complete(int id)
        {
            TodoItem todo = FindById(id);

            if (todo == null)
             throw new ArgumentException("Няма задача с такова ID");

            todo.Completed();
            
        }

        public void Delete(int id)
        {
            TodoItem todo = FindById(id);

            if (todo == null)
                throw new ArgumentException("Няма задача с такова ID");

            todos.Remove(todo);

        }

    }

    
}
