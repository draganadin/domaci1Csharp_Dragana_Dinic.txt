using System;

namespace Domaci2_KvadratKub
{
    class Program
    {
        public int KvadratKub(int a)
        {
            int b;
            if (a % 2 == 0)
            {
                b = a * a;
                Console.WriteLine("Kvadratni broj unetog broja je broj " + b);
            }
            else
            {
                b = a * a * a;
                Console.WriteLine("Kubni broj unetog broja je broj " + b);
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.Write("Unesite neki broj: ");
            int x = Convert.ToInt16(Console.ReadLine());
            int rezultat;

            Program n = new Program();
            rezultat = n.KvadratKub(x);
            Console.ReadLine();
        }
    }
}