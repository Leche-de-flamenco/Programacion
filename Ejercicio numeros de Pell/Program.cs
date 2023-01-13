using System.Net;

namespace Ejercicio_numeros_de_Pell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* la secuencia de números de Pell comienza con 0 y 1, 
             * y luego cada número de Pell se obtiene de los dos anteriores:
             * es la suma de dos veces el número de Pell anterior
             * y del número de Pell previo a este.Los primeros términos de la secuencia son
             0, 1, 2, 5, 12,*/
            int start = 0;
            int end = 15;
            int[] pell= new int[end];

            for (int i = 0; i < end; i++)
            {
                if (i < 2)
                {
                    pell[i] = start;
                    start++;
                    Console.Write(pell[1]+" | ");
                }
                else
                {
                    pell[i] = (pell[i - 2]) + (pell[i - 1] * 2);
                    start++;
                    Console.Write(pell[i] + " | ");
                }
               
            }
        }
    }
}