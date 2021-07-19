using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_35_ParosanErdekesek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a= 123;
            int forditott = 0;
            while (a!=0) {
            forditott = forditott * 10 + a % 10;
            a /= 10;
            }*/
            /*
            123
            a = 123 12 1 0
            forditott = 0 3 32 321

            */

            //Console.WriteLine(forditott);


            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    int a = i;
                    int forditott1 = 0;
                    while (a != 0)
                    {
                        forditott1 = forditott1 * 10 + a % 10;
                        a /= 10;
                    }

                    int b = j;
                    int forditott2 = 0;
                    while (b != 0)
                    {
                        forditott2 = forditott2 * 10 + b % 10;
                        b /= 10;
                    }

                    if (i * j == forditott1 * forditott2)
                    {
                        Console.WriteLine($"{i}*{j}={forditott1}*{forditott2}");
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
