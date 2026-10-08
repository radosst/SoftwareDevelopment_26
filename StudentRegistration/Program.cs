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
        }        
    }
}
