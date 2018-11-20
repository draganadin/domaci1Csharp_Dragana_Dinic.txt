using System;

namespace Domaci6_CicaMacaFja
{
    class Program
    {
        public void InputValues(ref int a, ref int b)
        {
            Console.WriteLine("Enter the starting number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void OutputValues(int a, int b)
        {
            int i;
            for (i = a; i < b; i++)
            {
                Console.Write("Number " + i);
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
                        Console.WriteLine(" is not divisible by 3 and 5!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int s = 1;
            int m = 2;
            Program n = new Program();
            n.InputValues(ref s, ref m);
            n.OutputValues(s, m);
            Console.ReadLine();
        }
    }
}
