using System;

namespace Domaci1_CicaMaca
{
    class Zadatak1
    {
        static void Main(string[] args)
        {

            int i;
            for (i = 1; i <= 100; i++)
            {
                Console.Write("Broj " + i);
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(": Cica Maca");
                    }
                    else
                    {
                        Console.WriteLine(": Cica");
                    }
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(": Maca");
                    }
                    else
                    {
                        Console.WriteLine(" nije deljiv ni sa 3 ni sa 5!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
