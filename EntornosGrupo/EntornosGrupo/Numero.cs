using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    class Numero
    {
        public static void Primo()
        {
            int numero;
            int Primo = 0;
            Console.Clear();
            Console.WriteLine("Escribe un numero para saber si es primo o no");
            numero = Validaciones.EnteroValidado();
            if ((numero < 2) || (numero % 2 == 0)) Primo++;
            else for (int i = 3; i < numero / 2; i++) if (numero % i == 0) { Primo++; break;}
            if (Primo > 0) Console.WriteLine("El numero introducido no es un numero primo");
            else Console.WriteLine("El numero introducido es un numero primo");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Factorial()
        {
            int numero;
            int factorial = 1;
            Console.Clear();
            Console.WriteLine("Escribe un numero para sacar el factorial");
            numero = Validaciones.EnteroValidado();
            for (int i = numero; i > 0; i--) factorial *= i;
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Segundos()
        {
            Console.Clear();
            Console.WriteLine("Escribe los segundos");
            int segundos = Validaciones.EnteroValidado();
            Console.WriteLine(string.Format("{0:d2}H:{1:d2}M:{2:d2}S", segundos / 3600, segundos / 60 % 60, segundos % 60));
            Console.ReadKey();
            Console.Clear();
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
            int numero;
            string cadena;
            int suma = 0;
            Console.Clear();
            Console.WriteLine("Introduce un numero para saber si es un numero Armstrong");
            numero = Validaciones.EnteroValidado();
            cadena = Convert.ToString(numero);
            foreach (char digito in cadena) suma += (int)Math.Pow(Convert.ToInt32(digito-'0'), 3);
            if (suma == numero) Console.WriteLine("Es un numero de Armstrong");
            else Console.WriteLine("No es un numero de Armstrong");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Digitos_diferentes()
        {
            int numero;
            string cadena;
            int cont = 0;
            Console.Clear();
            Console.WriteLine("Escribe un numero para comprobar si sus digitos son diferentes");
            numero = Validaciones.EnteroValidado();
            cadena = Convert.ToString(numero);
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = i+1;j<cadena.Length;j++)
                {
                    if (cadena[i] == cadena[j]) cont++;
                    if (cont == 1) break;
                }
            }
            if (cont == 1) Console.WriteLine("Hay al menos dos digitos iguales");
            else Console.WriteLine("Todos los digitos son diferentes");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
