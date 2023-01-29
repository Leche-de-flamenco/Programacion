using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    class Arrays
    {
        public static void Maximo()
        {
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            int maximo;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            maximo = inicial[0];
            foreach (int i in inicial) if (i> maximo) maximo = i;
            Console.WriteLine("El maximo es: "+maximo);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Minimo()
        {
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            int minimo;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            minimo = inicial[0];
            foreach (int i in inicial) if (i < minimo) minimo = i;
            Console.WriteLine("El maximo es: " + minimo);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Mediana()
        {
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            double mediana;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            Array.Sort(inicial);
            if (inicial.Length % 2 == 0)
            {
                int primeraMitad = inicial.Length / 2 - 1;
                int segundaMitad = inicial.Length / 2;
                mediana = (inicial[primeraMitad] + inicial[segundaMitad]) / 2.0;
            }
            else
            {
                int mitad = (inicial.Length - 1) / 2;
                mediana = inicial[mitad];
            }
            Console.WriteLine("La mediana es: "+mediana);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Media()
        {
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            int suma = 0;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                suma += inicial[cont];
                cont++;
            }
            Console.WriteLine("La media es: "+ suma/inicial.Length);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Ordenar()
        {
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            Array.Sort(inicial);
            foreach (int i in inicial) Console.Write(i+" | ");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Desviacion_tipica()
        {
            int numero;
            string entrada = "";
            int[] inicial = new int[1];
            int cont = 0;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            double media = inicial.Average();
            double desviacion = Math.Sqrt(inicial.Select(x => Math.Pow(x - media, 2)).Average());
            Console.WriteLine("La desviación típica es: "+ desviacion);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Binarizar()
        {
            int numero;
            string entrada = "";
            int[] inicial = new int[1];
            int[] binarizado;
            int cont = 0;
            Console.Clear();
            while (entrada != "end")
            {
                Console.WriteLine("Escribe un numero para introducir en el array. Para finalizar la recogida de datos escriba 'end'.");
                entrada = Console.ReadLine();
                if (entrada == "end") break;
                Array.Resize(ref inicial, cont + 1);
                inicial[cont] = int.Parse(entrada);
                cont++;
            }
            binarizado = new int[inicial.Length]; 
            Console.WriteLine("Escribe un valor para utilizarlo de referencia");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < inicial.Length; i++)
            {
                if (inicial[i] < numero) binarizado[i] = 0;
                else binarizado[i] = 1;
            }
            foreach (int i in binarizado) Console.Write(i);
            Console.ReadKey();
            Console.Clear();
        }
    }
}