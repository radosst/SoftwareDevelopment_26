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
                    throw new ArgumentException("Името не може да бъде празно или само интервали.", nameof(Name));
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
                    throw new ArgumentOutOfRangeException(nameof(Age), "Възрастта трябва да бъде между 6 и 20 години.");
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
                    throw new ArgumentOutOfRangeException(nameof(Grade), "Класът трябва да бъде между 1 и 12 включително.");
                grade = value;
            }
        }

        private double averageScore;
        public double AverageScore
        {
            get => averageScore;
            set
            {
                if (value < 2.00 || value > 6.00)
                    throw new ArgumentOutOfRangeException(nameof(AverageScore), "Средният успех трябва да бъде между 2.00 и 6.00 включително.");
                averageScore = value;
            }
        }

        private decimal fee;
        public decimal Fee
        {
            get => fee;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Fee), "Таксата не може да бъде отрицателна.");
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        private char classLetter;
        public char ClassLetter
        {
            get => classLetter;
            set
            {
                if (!char.IsLetter(value))
                    throw new ArgumentException("Паралелката трябва да е буква.", nameof(ClassLetter));
                classLetter = value;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException(nameof(BirthDate), "Датата на раждане не може да е бъдеща дата.");
                birthDate = value;
            }
        }

        public Student(string name, int age, int grade, double averageScore, decimal fee, bool hasScholarship, char classLetter, DateTime birthDate)
        {
            Id = nextId++;
            Name = name;
            Age = age;
            Grade = grade;
            AverageScore = averageScore;
            Fee = fee;
            HasScholarship = hasScholarship;
            ClassLetter = classLetter;
            BirthDate = birthDate;
        }
    }    
}

