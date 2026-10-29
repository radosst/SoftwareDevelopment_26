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
        private int nextID = 1;

        public List<TodoItem> GetAll()
        { 
           return todos;
        }

        public void Add(string title,string description,DateTime dueDate)
        {
            TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);
            todo.Add(todoItem);
            nextId++;
        }

        public TodoItem FindById(int id)
        {
            TodoItem targetTodo = null; 
            foreach (TodoItem todoItem in todos)
            {
                if (todoItem.Id == id)
                {
                    return todoItem;
                }

            }

            return targetTodo;
        }

        public void Completed (int id)
        {
            TodoItem todo = FindById(id);

            if (todo == null)
            {
                throw new ArgumentException
            }

        }

    }
}