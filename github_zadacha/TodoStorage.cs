using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using github_zadacha;

namespace github_zadacha
{
    internal class TodoStorage
    {
        public List<TodoItem> Todos { get; set; } = new List<TodoItem>();
        public int NextId { get; set; } = 1;
       
    }
}
