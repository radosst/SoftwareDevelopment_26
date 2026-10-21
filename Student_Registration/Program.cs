namespace Student_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ВЪВЕДЕТЕ ДАННИ ЗА УЧЕНИК ---");

            string name = ReadString("Име: ");
            int age = ReadInt("Възраст (6-20): ");
            int grade = ReadInt("Клас (1-12): ");
            double avgScore = ReadDouble("Среден успех (2.00-6.00): ");
            decimal fee = ReadDecimal("Такса: ");
            bool scholarship = ReadBool("Получава ли стипендия (true/false): ");
            char classLetter = ReadChar("Паралелка (буква): ");
            DateTime birthDate = ReadDate("Дата на раждане (dd.MM.yyyy): ");

            try
            {
                Student student = new Student(name, age, grade, avgScore, fee, scholarship, classLetter, birthDate);

                Console.WriteLine("\n--- ДАННИ ЗА УЧЕНИК ---");
                Console.WriteLine($"Id: {student.Id}");
                Console.WriteLine($"Име: {student.Name}");
                Console.WriteLine($"Възраст: {student.Age}");
                Console.WriteLine($"Клас: {student.Grade}");
                Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
                Console.WriteLine($"Такса: {student.Fee:F2} лв.");
                Console.WriteLine($"Стипендия: {(student.HasScholarship ? "Да" : "Не")}");
                Console.WriteLine($"Паралелка: {student.ClassLetter}");
                Console.WriteLine($"Дата на раждане: {student.BirthDate:dd.MM.yyyy}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }

            static string ReadString(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    try
                    {
                        if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException("Името не може да е празно.");
                        return input;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            static int ReadInt(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out int result)) return result;
                    Console.WriteLine("Невалидно цяло число. Въведете отново.");
                }
            }

            static double ReadDouble(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out double result)) return result;
                    Console.WriteLine("Невалидно число. Въведете отново.");
                }
            }

            static decimal ReadDecimal(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (decimal.TryParse(Console.ReadLine(), out decimal result)) return result;
                    Console.WriteLine("Невалидна сума. Въведете отново.");
                }
            }

            static bool ReadBool(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (bool.TryParse(Console.ReadLine(), out bool result)) return result;
                    Console.WriteLine("Моля въведете true или false.");
                }
            }
        }
    
    }
}
