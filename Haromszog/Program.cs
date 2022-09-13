using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ez a program kiszámolja egy háromszög kerületét és területét a megadott adatok alapján. A háromszög alapja minden esetben a 'c' oldal. Kérem minden adat megadása után való visszajelzést követően nyomjon egy gombot.");
            Console.WriteLine();
            Console.Write("Kérem a háromszög 'a' oldalát: ");
            double ao = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Az 'a' oldal hosszúsága {ao} cm.");
            Console.ReadLine();
            Console.Write("Kérem a háromszög 'b' oldalát: ");
            double bo = Convert.ToDouble(Console.ReadLine());
            Console.Write($"A 'b' oldal hosszúsága {bo} cm");
            Console.ReadLine();
            Console.Write("Kérem a háromszög 'c' oldalát: ");
            double co = Convert.ToDouble(Console.ReadLine());
            Console.Write($"A 'c' oldal hosszúsága {co} cm");
            Console.ReadLine();
            Console.Write("Kérem a háromszög magasságát: ");
            double mag = Convert.ToDouble(Console.ReadLine());
            Console.Write($"A magasság {mag} cm");
            Console.ReadLine();

            char val;
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("1. Kerület");

            Console.SetCursorPosition(20, 15);
            Console.WriteLine("2. Terület");

            Console.SetCursorPosition(20, 16);
            Console.WriteLine("3. Kilépés");

            Console.SetCursorPosition(35, 18);
            Console.WriteLine("Kérem adja meg a választott eljárás számát: ");
            val = Char.Parse(Console.ReadLine());

            switch (val)
            {
                case '1':
                    Console.Write($"A téglalap kerülete {ao + bo + co} cm");
                    Console.ReadLine();
                    break;

                case '2':
                    Console.Write($"A téglalap területe {(ao * 0.5) * mag} cm2");
                    Console.ReadLine();
                    break;

                case '3':
                    break;
            }
        }
    }
}


