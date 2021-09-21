using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopDenemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, j, gec;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz :", i + 1);
                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (i = 0; i < 4; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (a[i] < a[j])
                    {
                        gec = a[i];
                        a[i] = a[j];
                        a[j] = gec;
                    }
                }
            }
            Console.WriteLine();

            foreach (var dizi in a)
            {
                Console.Write("{0} ", dizi);
            }

            Console.ReadKey();
        }
    }
}
