using System;

namespace Domaci3_ProizvodRazlikaKolicnik
{
    class Zadatak3
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Unesite bilo koja dva realna broja.");
            Console.WriteLine("Ukoliko oba broja budu parna, računaćemo njihov proizvod.");
            Console.WriteLine("Ukoliko oba broja budu neparna, računaćemo količnik.");
            Console.WriteLine("U slučaju da jedan broj bude paran a drugi neparan, biće izračunata njihova razlika.\n");
            Console.Write("Unesite prvi broj:");
            double n = double.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj:");
            double m = double.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                if (m % 2 == 0)
                {
                    x = n * m;
                    Console.WriteLine("Uneli ste dva parna broja. Njihov proizvod iznosi: " + x);
                }
                else
                {
                    y = n - m;
                    Console.WriteLine("Uneli ste jedan paran i jedan neparan broj. Njihova razlika iznosi: " + Math.Abs(y));
                }
            }
            else
            {
                if (m % 2 == 0)
                {
                    y = n - m;
                    Console.WriteLine("Uneli ste jedan paran i jedan neparan broj. Njihova razlika iznosi: " + Math.Abs(y));
                }
                else
                {
                    z = n / m;
                    Console.WriteLine("Uneli ste dva neparna broja. Njihov količnik iznosi: " + z);
                }
            }         
            Console.ReadKey();
        }
    }
}