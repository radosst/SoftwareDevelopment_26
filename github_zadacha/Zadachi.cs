using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_zadacha
{
    internal class Zadachi
    {
        public string Zaglavie { get; set; }
        public string Opisanie { get; set; }
        public string KraenSrok { get; set; }
        public string Sustoqnie { get; set; }

        public Zadachi(string title,string desc,string dl,string state)
        {
            Zaglavie = title;
            Opisanie = desc;
            KraenSrok = dl;
            Sustoqnie = state;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Заглавие: {Zaglavie} | Описание: {Opisanie} | Краен Срок: {KraenSrok} | Изпълнена или не: {Sustoqnie} ");
        }

        public string ToFileFormat()
        {
            return $"{Zaglavie},{Opisanie},{KraenSrok},{Sustoqnie}";
        }
    }
}
