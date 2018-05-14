using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fakts();
            Cipars();
            Zvaigznite();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            ReizTabula();
            Console.ReadLine();
        }
        static void ReizTabula()
        {
            Console.WriteLine("Ievadiet skaitli:");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);
            }
        }
        static void Zvaigznite()
        {
            string simbols = "";

            for (int i = 1; i < 5; i++)
            {
                simbols = simbols + "*";
                Console.WriteLine(simbols);
            }
        }
        static void Cipars()
        {
            Console.WriteLine("Ievadiet skaitli:");
            int cipars = 0;
            string ievade1 = Console.ReadLine();
            int skaitlis1 = Convert.ToInt16(ievade1);
            for (int i = 1; i <= skaitlis1; i++)
            {
                cipars = cipars + 1;
                Console.WriteLine(cipars + "+" + skaitlis1);
            }

        }
        static void Fakts()
        {
            int vertiba = 0;
            string ievade = Console.ReadLine();
            int robeza = Convert.ToInt16(ievade);
            for (int i = 1; i<=robeza; i++)
            {
                vertiba = vertiba + i;
                Console.WriteLine(vertiba);
            }
        }
    }
}
