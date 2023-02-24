using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace arvausPeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arvausLista = new List<int>();
            Random random = new Random();

            int randomNum = random.Next(1, 100);

            int Arvaus = 0;
            int i = 0;

            Console.WriteLine("Tervetuloa arvaus peliin! Arvaa numero 1-100 väliltä?");

            while (Arvaus != randomNum)

            {

                if (!int.TryParse(Console.ReadLine(), out Arvaus))
                {
                    Console.WriteLine("Arvaa luku");
                    continue;
                }
                else
                {
                    arvausLista.Add(Arvaus);
                }

                if (Arvaus < randomNum)
                {
                    Console.WriteLine($"Numero on suurempi kuin {Arvaus}.");
                }
                else if (Arvaus > randomNum)
                {
                    Console.WriteLine($"Numero on pienempi kuin {Arvaus}.");
                }

                i++;


            }

            Console.WriteLine($"Hienoa, oikea vastaus on {randomNum}!");
            Console.WriteLine("Arvasit " + i + " kertaa.");
            Console.WriteLine("Arvauksiasi olivat:");
            Console.WriteLine(string.Join("\n", arvausLista.ToArray()));
            Console.ReadLine();
        }
    }
}