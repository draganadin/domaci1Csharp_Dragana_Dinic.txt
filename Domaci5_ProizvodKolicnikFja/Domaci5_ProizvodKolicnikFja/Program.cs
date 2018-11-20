using System;

namespace Domaci5_ProizvodKolicnikFja
{
    class Program
    {
        public int EvenOdd(int a, int b)
        {
            int c;
            if (a % 2 == 0)
            {
                if (b % 2 == 0)
                {
                    c = a * b;
                    Console.WriteLine("Uneli ste dva parna broja. Njihov proizvod iznosi: " + c);
                }
                else
                {
                    c = a - b;
                    Console.WriteLine("Uneli ste jedan paran i jedan neparan broj. Njihova razlika iznosi: " + Math.Abs(c));
                }
            }
            else
            {
                if (b % 2 == 0)
                {
                    c = a - b;
                    Console.WriteLine("Uneli ste jedan paran i jedan neparan broj. Njihova razlika iznosi: " + Math.Abs(c));
                }
                else
                {
                    c = a / b;
                    Console.WriteLine("Uneli ste dva neparna broja. Njihov količnik iznosi: " + c);
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite bilo koja dva realna broja.");
            Console.WriteLine("Ukoliko oba broja budu parna, računaćemo njihov proizvod.");
            Console.WriteLine("Ukoliko oba broja budu neparna, računaćemo količnik.");
            Console.WriteLine("U slučaju da jedan broj bude paran a drugi neparan, biće izračunata njihova razlika.\n");
            Console.Write("Unesite prvi broj:");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Unesite drugi broj:");
            int y = Convert.ToInt16(Console.ReadLine());
            int z;

            Program n = new Program();
            z = n.EvenOdd(x, y);
            Console.ReadLine();
        }
    }
}
