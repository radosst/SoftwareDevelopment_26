using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //зад.1
            Console.Write("Въведете възраст:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out  age))
            {
                Console.WriteLine("Невалидна възраст.");
                Console.Write("Въведете възраст:");
            }
            Console.WriteLine($"Възраст: {age}");


            //zad.2
            Console.Write("Въведете клас:");
            byte grade;
            while (!byte.TryParse(Console.ReadLine(), out  grade))
            {
                Console.WriteLine("Невалиден клас.");
                Console.Write("Въведете клас:");
            }
            Console.WriteLine($"Клас: {grade}");


            //zad.3
            Console.Write("Въведете среден успех:");
            double averegegrade;
            while (!double.TryParse(Console.ReadLine(), out  averegegrade))
            {
                Console.WriteLine("Невалиден успех.");
                Console.Write("Въведете среден успех:");

            }
            Console.WriteLine($"Среден успех: {averegegrade}");

            //zad.4
            Console.Write("Въведете такса:");
            decimal payment;
            while (!decimal.TryParse(Console.ReadLine(), out payment))
            {
                Console.WriteLine("Невалидена такса.");
                Console.Write("Въведете такса:");

            }
            Console.WriteLine($"Такса: {payment}");

            //zad.5
            Console.Write("Въведете има ли стипендия:");
            bool scholarship;
            while (!bool.TryParse(Console.ReadLine(), out scholarship))
            {
                Console.WriteLine("Невалидена стипендия.");
                Console.Write("Въведете има лои стипендия:");

            }
            Console.WriteLine($"Стипендия: {scholarship}");
        }        
    }
}
