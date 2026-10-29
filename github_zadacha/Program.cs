using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace TodoManager
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("======= TODO MANAGER ========");
                Console.WriteLine("1. Добави задача");
                Console.WriteLine("2. Покажи задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("x. Изход");

                Console.WriteLine();
                Console.Write("Избор: ");
                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1": { AddTodo(); break; }
                        case "2": { ListAllTodos(); break; }
                        case "3": { CompleteTodo(); break; }
                        case "4": { DeleteTodo(); break; }
                        case "x": { Console.WriteLine("Край на програмата"); Console.ReadLine(); return; }
                        default: { Console.WriteLine("Невалиден избор."); break; }
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

        private static void DeleteTodo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=====  Изтрий задача =======\n");
            ListAllTodos();

            Console.Write("Избери Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Невалидно id.");
                Console.Write("Избери Id: ");
            }

            TodoItem deleteTask = FindById(id);

            tasks.Remove(deleteTask);
            Console.WriteLine("Задачата е изтрита.");

        }

        private static void CompleteTodo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=====  Маркирай задача като завършена =======\n");
            ListAllTodos();

            Console.Write("Избери Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Невалидно id.");
                Console.Write("Избери Id: ");
            }

            Console.WriteLine("Задачата е завършена.");


        }

        private static void ListAllTodos()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("===== Всички задачи  =======");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи");
            }
            else
            {
                foreach (TodoItem todoItem in tasks)
                {
                    Console.WriteLine($"{todoItem}");
                }
            }
        }

       

        private static void AddTodo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=====  Добавяне на задача =======");

            Console.Write("Заглавие:");
            string title = Console.ReadLine();

            Console.Write("Описание:");
            string description = Console.ReadLine();

            Console.Write("Краен срок:");
            DateTime dueDate;
            while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
            {
                Console.WriteLine("Невалидна дата.Въведи отово!");
                Console.Write("Краен срок: ");
            }

            TodoItem todoItem = new TodoItem(nextId, title, description, dueDate);
            tasks.Add(todoItem);
            nextId++;
            Console.WriteLine("Задачата е добавена.");












            //        namespace github_zadacha
            //{
            //    internal class Program

            //    {
            //        static string filePath = "zad.txt";
            //        static List<Zadachi> zadachi = new List<Zadachi>();
            //        private static int nextID = 1;
            //        static void Main(string[] args)
            //        {
            //            LoadZadachiFromFile();
            //            while (true)
            //            {
            //                Console.WriteLine("---Menu---");
            //                Console.WriteLine("1.Добави нова задача");
            //                Console.WriteLine("2.Виж всички въведени задачи");
            //                Console.WriteLine("3.Маркирай задачата като изпълнена");
            //                Console.WriteLine("4.Изтрий задача");
            //                Console.WriteLine("5.Спри");

            //                string coice = Console.ReadLine();

            //                if (coice == "1")
            //                {
            //                    AddNewZadacha();
            //                }
            //                else if (coice == "2")
            //                {
            //                    CheckZadachi();
            //                }
            //                else if (coice == "3")
            //                {
            //                    MarkZadachi();
            //                }
            //                else if (coice == "4")
            //                {
            //                    DeleteZadacha();
            //                }
            //                else if (coice == "5")
            //                {
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Невалиден избор.");
            //                }

            //            }

            //            static void LoadZadachiFromFile()
            //            {
            //                if (!File.Exists(filePath))
            //                {
            //                    File.Create(filePath).Close();
            //                    return;
            //                }

            //                string[] lines = File.ReadAllLines(filePath);
            //                for (int i = 0; i < lines.Length; i++)
            //                {
            //                    if (string.IsNullOrWhiteSpace(lines[i])) continue;

            //                    string[] parts = lines[i].Split(',');
            //                    if (parts.Length == 6)
            //                    {
            //                        string title = parts[0];
            //                        string desc = parts[1];
            //                        string dl = parts[2];
            //                        string state = parts[3];


            //                        Zadachi z = new Zadachi(nextID, title, desc, dl, state);
            //                        zadachi.Add(z);
            //                    }
            //                }
            //            }

            //            static void SaveZadachiToFile()
            //            {
            //                List<string> lines = new List<string>();
            //                for (int i = 0; i < zadachi.Count; i++)
            //                {
            //                    lines.Add(zadachi[i].ToFileFormat());
            //                }
            //                File.WriteAllLines(filePath, lines);
            //            }

            //            static void AddNewZadacha()
            //            {
            //                Console.WriteLine("Въведи заглавие на новата задача:");
            //                string title = Console.ReadLine();

            //                Console.WriteLine("Въведи описание на новата задача:");
            //                string desc = Console.ReadLine();

            //                Console.WriteLine("Въведи краен срок на новата задача:");
            //                string dl = Console.ReadLine();

            //                Console.WriteLine("Въведи дали новата задача е изпълнена:");
            //                string state = Console.ReadLine();

            //                Zadachi newZad = new Zadachi(nextID, title, desc, dl, state);

            //                zadachi.Add(newZad);

            //                SaveZadachiToFile();
            //                Console.WriteLine("Задачата е добавена!");
            //            }

            //            static void CheckZadachi()
            //            {
            //                if (zadachi.Count == 0)
            //                {
            //                    Console.WriteLine("Няма налични задачи.");
            //                    return;
            //                }

            //                for (int i = 0; i < zadachi.Count; i++)
            //                {
            //                    Console.Write($"{i + 1}.");
            //                    zadachi[i].PrintInfo();
            //                }
            //            }

            //            static void MarkZadachi()
            //            {
            //                CheckZadachi();
            //                if (zadachi.Count == 0) return;
            //                else
            //                {
            //                    Console.Write("Въведете номер на задача за маркиране: ");
            //                    int index = int.Parse(Console.ReadLine()) - 1;
            //                    if (index >= 0 && index < zadachi.Count)
            //                    {
            //                        zadachi[index].Sustoqnie = "Изпълнена";
            //                        Console.WriteLine("Задачата е маркирана");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Няма такава задача!");
            //                    }
            //                }


            //            }

            //            static void DeleteZadacha()
            //            {
            //                CheckZadachi();
            //                if (zadachi.Count == 0) return;
            //                else
            //                {
            //                    Console.Write("Въведете номера на задачата която искате да изтриете: ");
            //                    int index = int.Parse(Console.ReadLine()) - 1;
            //                    if (index >= 0 && index < zadachi.Count)
            //                    {
            //                        zadachi.RemoveAt(index);
            //                        Console.WriteLine("Задачата е изтрита.");
            //                    }
            //                }
            //            }


        }
    }
}

