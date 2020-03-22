using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Pascal_Ucgeni_Uretme
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            string k = "", h = "";

            Console.Write("Basamak sayısını girin:");

            x = Convert.ToInt32(Console.ReadLine());

            int[] m = new int[x];

            for (int g = 1; g <= x; g++) k += " ";

            if (x == 1) Console.Write("{0} 1", k);

            if (x == 2) Console.Write("{0}1\n 1 1", k);

            k = "";

            if (x > 2)
            {

                for (int g = x; g >= 0; g--) h += " ";

                Console.WriteLine("{0}1", h);

                h = "";

                for (int g = x; g >= 1; g--) h += " ";

                Console.WriteLine("{0}1 1", h);

                h = "";

                m[0] = 1;
                m[1] = 1;

                for (int i = 2; i < x; i++)
                {

                    int[] m1 = new int[i];

                    for (y = 1; y < i; y++)
                    {

                        m1[y] = m[y] + m[y - 1];

                        k = k + " " + m1[y].ToString();

                    }

                    for (y = 1; y < i; y++)
                    {

                        m[y] = m1[y];

                    }

                    m[i] = 1;

                    for (int g = x; g >= i; g--) h += " ";

                    Console.WriteLine("{1}1{0} 1", k, h);

                    h = "";

                    k = "";

                }

            }

            Console.ReadKey(); 
        }
    }
}
