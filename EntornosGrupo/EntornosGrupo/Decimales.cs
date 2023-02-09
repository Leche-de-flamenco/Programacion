using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    internal class Decimales
    {
        public static void Redondear_Alza()
        {
            Console.Clear();
            Console.WriteLine("Escribe el numero que quieres redondear al alza");
            decimal numero = Validaciones.DecimalValidado();
            Console.WriteLine(Math.Ceiling(numero));
            Console.ReadKey();
            Console.Clear();
        }
        public static void Eliminar_Decimales()
        {
            Console.Clear();
            int numero;
            decimal numeroD;
            Console.WriteLine("Escibe un numero decimal al cual quieras eliminar los decimales");
            numeroD = Validaciones.DecimalValidado();
            numero = (int)(numeroD / 1);
            Console.WriteLine(numero);
            Console.ReadKey();
            Console.Clear();
        }
        public static void Ecuacion_2º()
        {
            Console.Clear();
            double a, b, c, resultadoP, resultadoN;
            Console.WriteLine("Escribe 3 coeficientes para realizar un ecuacion de 2º grado");
            Console.WriteLine("Escriba el valor de a");
            a = Validaciones.DoubleValidado();
            Console.WriteLine("Escriba el valor de b");
            b = Validaciones.DoubleValidado();
            Console.WriteLine("Escriba el valor de c");
            c = Validaciones.DoubleValidado();
            resultadoP = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            resultadoN = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            if (resultadoP == resultadoN)
                Console.WriteLine(resultadoP);
            else
                Console.WriteLine(resultadoP + " " + resultadoN);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
