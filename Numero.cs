using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    class Numero
    {
        public static void Primo()
        {

        }
        public static void Factorial()
        {

        }
        public static void Segundos()
        {

        }
        public static void Pell()
        {
            int start = 0;
            int end = 15;
            int[] pell = new int[end];
            Console.Clear();
            for (int i = 0; i < end; i++)
            {
                if (i < 2)
                {
                    pell[i] = start;
                    start++;
                    Console.Write(pell[1] + " | ");
                }
                else
                {
                    pell[i] = (pell[i - 2]) + (pell[i - 1] * 2);
                    start++;
                    Console.Write(pell[i] + " | ");
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
        public static void Armstrong()
        {

        }
        public static void Digitos_diferentes()
        {

        }
    }
}
