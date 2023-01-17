using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    internal class String
    {
        public static void Palindromo()
        {
            string cadena;
            string aux = "";
            string auxInversa = "";
            Console.Clear();
            Console.WriteLine("Introduce una cadena para saber si es un palindromo");
            cadena = Console.ReadLine(); cadena = cadena.ToLower();
            foreach (char caracter in cadena) if (caracter != ' ') aux += caracter;
            for (int i = aux.Length - 1; -1 < i; i--) auxInversa += aux[i];
            if (aux == auxInversa) Console.WriteLine("La cadena introducida es un palindromo");
            else Console.WriteLine("La cadena no es un palindromo");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Mayusculas_minusculas()
        {
            string cadena;
            Console.Clear();
            Console.WriteLine("Escribe una cadena");
            cadena = Console.ReadLine();
            Console.WriteLine("Todo en mayusculas: " + cadena.ToUpper());
            Console.WriteLine("Todo en minusculas: " + cadena.ToLower());
            Console.ReadKey();
            Console.Clear();
        }
        public static void Ocurrencias()
        {
            string cadena;
            char letra;
            int cont = 0;
            Console.Clear();
            Console.WriteLine("Escribe una cadena");
            cadena = Console.ReadLine();
            Console.WriteLine("Escribe la letra que quieres contar");
            letra = char.Parse(Console.ReadLine());
            foreach (char caracter in cadena) if (letra == caracter) cont++;
            Console.WriteLine("La letra '" + letra + "' aparece " + cont + " veces.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Repetir_strings()
        {
            string cadena;
            string cadena2;
            string repetir;
            int veces;
            Console.Clear();
            Console.WriteLine("Escribe una cadena");
            cadena = Console.ReadLine();
            Console.WriteLine("Escribe la segunda cadena");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Escribe el numero de veces que quieres repetir la concatenacion de las cadenas anteriores");
            veces = int.Parse(Console.ReadLine());
            repetir = cadena + " " + cadena2;
            for (int i = 0; i < veces - 1; i++) repetir += " " + repetir;
            Console.WriteLine(repetir);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Repetir_letra()
        {
            string cadena;
            string resultado = "";
            Console.Clear();
            Console.WriteLine("Escribe una cadena de texto");
            cadena = Console.ReadLine();
            foreach (char letra in cadena)
            {
                resultado += letra;
                resultado += letra;
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Eliminar_cadena()
        {
            string cadena;
            string borrar;
            string resultado;
            Console.Clear();
            Console.WriteLine("Escribe una cadena de texto");
            cadena = Console.ReadLine(); cadena = cadena.ToLower();
            Console.WriteLine("Escribe el texto que quieras borrar del primer string");
            borrar = Console.ReadLine(); borrar = borrar.ToLower();
            resultado = cadena.Replace(borrar, "");
            Console.WriteLine(resultado.Trim());
            Console.ReadKey();
            Console.Clear();
        }
    }
}