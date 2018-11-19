using System;

namespace Domaci2_KvadratKub
{
    class Zadatak2
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite bilo koji broj: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                int z = n * n;
                Console.WriteLine("Kvadratni broj unetog broja je broj " + z);
            }
            else
            {
                int y = n * n * n;
                Console.WriteLine("Kubni broj unetog broja je broj " + y);
            }
            Console.ReadKey();
        }
    }
}