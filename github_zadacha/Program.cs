using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace github_zadacha
{
    internal class Program
    {
        static string filePath = "zad.txt";
        static List<Zadachi> zadachi = new List<Zadachi>();
        static void Main(string[] args)
        {
            LoadZadachiFromFile();
            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1.Добави нова задача");
                Console.WriteLine("2.Виж всички въведени задачи");
                Console.WriteLine("3.Маркирай задачата като изпълнена");
                Console.WriteLine("4.Изтрий задача");
                Console.WriteLine("5.Спри");

                string coice = Console.ReadLine();

                if (coice == "1")
                {
                    AddNewZadacha();
                }
                else if (coice == "2")
                {
                    CheckZadachi();
                }
                else if (coice == "3")
                {
                    MarkZadachi();
                }
                else if (coice == "4")
                {
                     DeleteZadacha();
                }
                else if (coice == "5")
                {
                     break;
                }
                else
                {
                    Console.WriteLine("Невалиден избор.");
                }

            }

            static void LoadZadachiFromFile()
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;

                    string[] parts = lines[i].Split(',');
                    if (parts.Length == 6)
                    {
                        string title = parts[0];
                        string desc = parts[1];
                        string dl = parts[2];
                        string state = parts[3];


                        Zadachi z = new Zadachi(title, desc, dl, state);
                        zadachi.Add(z);
                    }
                }
            }

            static void SaveZadachiToFile()
            {
                List<string> lines = new List<string>();
                for (int i = 0; i < zadachi.Count; i++)
                {
                    lines.Add(zadachi[i].ToFileFormat());
                }
                File.WriteAllLines(filePath, lines);
            }

            static void AddNewZadacha()
            {
                Console.WriteLine("Въведи заглавие на новата задача:");
                string title = Console.ReadLine();

                Console.WriteLine("Въведи описание на новата задача:");
                string desc = Console.ReadLine();

                Console.WriteLine("Въведи краен срок на новата задача:");
                string dl = Console.ReadLine();

                Console.WriteLine("Въведи дали новата задача е изпълнена:");
                string state = Console.ReadLine();

                Zadachi newZad = new Zadachi(title, desc, dl, state);
                zadachi.Add(newZad);

                SaveZadachiToFile();
                Console.WriteLine("Задачата е добавена!");
                }

            static void CheckZadachi()
            {
                if (zadachi.Count == 0)
                {
                    Console.WriteLine("Няма налични задачи.");
                    return;
                }

                for (int i = 0; i < zadachi.Count; i++)
                {
                    Console.Write($"{i+1}.");
                    zadachi[i].PrintInfo();
                }
            }
            
            static void MarkZadachi()
            {
                CheckZadachi();
                if (zadachi.Count == 0) return;
                else
                {
                    Console.Write("Въведете номер на задача за маркиране: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 0 && index < zadachi.Count)
                    {
                        zadachi[index].Sustoqnie="Изпълнена";
                        Console.WriteLine("Задачата е маркирана");
                    }
                    else
                    {
                        Console.WriteLine("Няма такава задача!");
                    }
                }


            }

            static void DeleteZadacha()
            {
                CheckZadachi();
                if (zadachi.Count == 0) return;
                else 
                {
                    Console.Write("Въведете номера на задачата която искате да изтриете: ");
                    int index=int.Parse( Console.ReadLine())-1;
                    if(index>=0 && index<zadachi.Count)
                    {
                        zadachi.RemoveAt(index);
                        Console.WriteLine("Задачата е изтрита.");
                    }
                }
            }

        }
    }
} 
