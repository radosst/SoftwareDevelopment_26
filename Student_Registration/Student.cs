using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    internal class Student
    {
        private static int nextId = 1;
        public int Id { get; private set; }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Името не може да бъде празно или само интервали.");
                name = value;
            }
        }

        
    }    
}

