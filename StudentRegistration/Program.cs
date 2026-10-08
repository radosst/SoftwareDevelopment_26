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
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Възраст: {age}");
            }
            else
            {
                Console.WriteLine("Невалидна възраст.");
            }

            //zad.2
            Console.Write("Въведете клас:");
            if (byte.TryParse(Console.ReadLine(), out byte grade))
            {
               Console.WriteLine($"Клас: {grade}");
            }
            else
            {
                Console.WriteLine("Невалиден клас.");
            }

            //zad.3
            Console.Write("Въведете среден успех:");
            if (double.TryParse(Console.ReadLine(), out double averegegrade))
            {
                Console.WriteLine($"Среден успех: {averegegrade}");
            }
            else
            {
                Console.WriteLine("Невалиден успех.");
            }
        }        
    }
}
