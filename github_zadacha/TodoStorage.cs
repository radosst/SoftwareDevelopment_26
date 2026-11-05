using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager;

namespace github_zadacha
{
    internal class TodoStorage
    {
        public List<TodoItem> Todos {  get; set; }
        public int NextId { get; set; } = 1;
    }
}
