namespace Student_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- ВЪВЕДЕТЕ ДАННИ ЗА УЧЕНИК ---");

            string name = ReadString("Име: ");
            int age = ReadInt("Възраст (6-20): ", 6, 20);
            int grade = ReadInt("Клас (1-12): ", 1, 12);
            double avgScore = ReadDouble("Среден успех (2.00-6.00): ", 2.00, 6.00);
            decimal fee = ReadDecimal("Такса: ", 0);
            bool scholarship = ReadBool("Получава ли стипендия (true/false): ");
            char classLetter = ReadChar("Паралелка (буква): ");
            DateTime birthDate = ReadDate("Дата на раждане (dd.MM.yyyy): ");

            try
            {
                Student student = new Student(name, age, grade, avgScore, fee, scholarship, classLetter, birthDate);

                Console.WriteLine("\n=== ДАННИ ЗА УЧЕНИК ===");
                Console.WriteLine();
                Console.WriteLine($"Id: {student.Id}");
                Console.WriteLine($"Име: {student.Name}");
                Console.WriteLine($"Възраст: {student.Age}");
                Console.WriteLine($"Клас: {student.Grade}");
                Console.WriteLine($"Среден успех: {student.AverageScore:F2}");
                Console.WriteLine($"Такса: {student.Fee:F2} евро");
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

                    if (!string.IsNullOrEmpty(input))
                    {
                        bool isOnlyLetters = true;
                        foreach (char c in input)
                        {
                            if (!char.IsLetter(c) && c != ' ' && c != '-')
                            {
                                isOnlyLetters = false;
                                break;
                            }
                        }
                        if (isOnlyLetters)
                        {
                            return input;
                        }
                    }

                    Console.WriteLine("Името трябва да съдържа само букви и не може да е празно. Въведете отново.");
                }
            }

            static int ReadInt(string prompt, int min, int max)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
                    {
                        return result;
                    }
                    Console.WriteLine($"Невалидно число! Трябва да е между {min} и {max}.");
                }
            }

            static double ReadDouble(string prompt, double min, double max)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out double result) && result >= min && result <= max)
                    {
                        return result;
                    }
                    Console.WriteLine($"Невалиден успех! Трябва да е между {min:F2} и {max:F2}.");
                }
            }

            static decimal ReadDecimal(string prompt, decimal min)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (decimal.TryParse(Console.ReadLine(), out decimal result) && result >= min)
                    {
                        return result;
                    }
                    Console.WriteLine($"Невалидна такса! Не може да е по-малко от {min}.");
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

            static char ReadChar(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsLetter(input[0]))
                        return input[0];
                    Console.WriteLine("Моля въведете една буква.");
                }
            }

            static DateTime ReadDate(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime result)) return result;
                    Console.WriteLine("Невалидна дата. Въведете във формат dd.MM.yyyy.");
                }
            }
        }
    
    }
}
