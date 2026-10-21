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

        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 6 || value > 20)
                    throw new ArgumentOutOfRangeException("Възрастта трябва да бъде между 6 и 20 години.");
                age = value;
            }
        }

        private int grade;
        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Класът трябва да бъде между 1 и 12 включително.");
                grade = value;
            }
        }

    }    
}

