using System.Runtime.CompilerServices;
using System.Text;

namespace Exam_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClubRepository clubRepository = new ClubRepository("clubs.json");
            ClubService clubService = new ClubService(clubRepository);


            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Добавяне на клуб");
                Console.WriteLine("2. Показване на всички клубове");
                Console.WriteLine("3. Изтриване на клуб по Id");
                Console.WriteLine("4. Филтриране по дата");
                Console.WriteLine("0. Изход");
                Console.Write("Избор: ");


                switch (Console.ReadLine())
                {
                    case "1":
                        Add(clubService);
                        break;
                    case "2":
                        ShowAll(clubService);
                        break;
                    case "3":
                        Delete(clubService);
                        break;
                    case "4":
                        FilterByDate(clubService);
                        break;
                    case "0":
                    case null:
                        return;
                }
            }
        }

        static void Add(ClubService service)
        {
            Console.Clear();

            Console.Write("Въведи име: ");
            string name = Console.ReadLine();
            Console.Write("Въведи ден: ");
            DateOnly day;
           
            while (!DateOnly.TryParse(Console.ReadLine(), out day))
            {
                Console.Write("Невалиден формат. Опитай пак: ");
            }

            try
            {
                service.AddClub(name, day);
                Console.WriteLine("The club is added");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Greshka: {ex.Message}");
            }

        }

        static void ShowAll(ClubService service)
        {
            Console.Clear();
           
            var clubs = service.GetAllClubs();

            if (clubs == null || clubs.Count == 0)
            {
                Console.WriteLine("Nqma nalichni klubove.");
                return; 
            }
          
            foreach (Club club in clubs)
            {
                Console.WriteLine($"Id:{club.Id} | Ime:{club.Name} | Data:{club.Date} ");
            }
        }

        static void Delete(ClubService service)
        {
            Console.Clear();
            Console.WriteLine("--- Spisuk s nalichni klubove ---");
            ShowAll(service); 
            Console.WriteLine("---------------------------------");

            Console.Write("Vuvedi Id na kluba za iztrivane: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Nevaliden vhod. Trqbva da e chislo.");
                return;
            }

            try
            {
                service.DeleteClub(id);
                Console.WriteLine(" Klubyt e iztrit uspeshno!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($" Greshka: {ex.Message}");
            }
        }

        static void FilterByDate(ClubService service)
        {
            Console.Clear();

            DateOnly dateOnly = new DateOnly();
            Console.Write("Избеви ден:");
            while (!DateOnly.TryParse(Console.ReadLine(), out dateOnly))
            {
                Console.WriteLine("Невалиден ден. Опитай пак: ");
            }

            var filteredClubs=service.GetClubsByDate(dateOnly);

            if(filteredClubs == null)
            {
                Console.WriteLine("Za tazi data nqma klubove");
                return;
            }

            foreach(var club in filteredClubs)
            {
                Console.WriteLine($"Id:{club.Id} | Ime:{club.Name} | Data:{club.Date} ");
            }

        }
    }
}
    

