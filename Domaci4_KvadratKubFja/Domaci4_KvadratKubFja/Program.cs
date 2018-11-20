using System;

namespace Domaci4_KvadratKubFja
{
    class Program
    {
        public int KvadratKub(int a)
        {
            if (a % 2 == 0)
            {
                a = a * a;
                Console.WriteLine("Kvadratni broj unetog broja je broj " + a);
            }
            else
            {
                a = a * a * a;
                Console.WriteLine("Kubni broj unetog broja je broj " + a);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Unesite neki broj: ");
            int x = Convert.ToInt16(Console.ReadLine());

            Program n = new Program();
            x = n.KvadratKub(x);
            Console.ReadLine();
        }
    }
}