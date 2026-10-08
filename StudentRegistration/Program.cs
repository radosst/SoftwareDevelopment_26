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
            Console.WriteLine("Въведете възраст:");
            while (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Възраст: {age}");
            }
             Console.WriteLine("Невалидна възраст."); 

            
        }
    }
}
