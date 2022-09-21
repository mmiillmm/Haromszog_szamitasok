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
            Console.Write("Kérem a háromszög 'c' oldalát: ");
            double co = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a háromszög 'b' oldalát: ");
            double bo = Convert.ToDouble(Console.ReadLine());

            bool firstloop = true;

            while (bo > co)
            {
                if (firstloop == false)
                {
                    Console.WriteLine("Haver...");
                }

                Console.WriteLine();
                Console.WriteLine("A megadott adat nem megfelelő. Adj meg újat: ");
                bo = int.Parse(Console.ReadLine());

                firstloop = false;
            }
            Console.Write("Kérem a háromszög 'a' oldalát: ");
            double ao = Convert.ToDouble(Console.ReadLine());

            bool secondloop = true;

            while (ao > co)
            {
                if (secondloop == false)
                {
                    Console.WriteLine("Haver...");
                }

                Console.WriteLine();
                Console.WriteLine("A megadott adat nem megfelelő. Adj meg újat: ");
                ao = int.Parse(Console.ReadLine());

                secondloop = false;
            }

            Console.Write("Kérem a háromszög magasságát: ");
            double mag = Convert.ToDouble(Console.ReadLine());

            char val;
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("1. Kerület");

            Console.SetCursorPosition(30, 15);
            Console.WriteLine("2. Terület");

            Console.SetCursorPosition(30, 16);
            Console.WriteLine("3. Kilépés");

            Console.SetCursorPosition(45, 18);
            Console.WriteLine("Kérem adja meg a választott eljárás számát: ");
            val = Char.Parse(Console.ReadLine());

            switch (val)
            {
                case '1':
                    Console.Write($"A téglalap kerülete {ao + bo + co} cm");
                    Console.ReadLine();
                    break;

                case '2':
                    Console.Write($"A téglalap területe {(co * mag) * 0.5} cm2");
                    Console.ReadLine();
                    break;

                case '3':
                    break;

                default:
                    Console.WriteLine("Nincs ilyen menüpont.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}


