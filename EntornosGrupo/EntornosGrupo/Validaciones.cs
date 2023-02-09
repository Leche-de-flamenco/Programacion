using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entornos
{
    class Validaciones
    {
        public static int EnteroValidado()
        {
            int aux;
            while (!int.TryParse(Console.ReadLine(),out aux))
                Console.WriteLine("Error! Debe de ser un numero entero (Tipo de dato int)");
            return aux;
        }
        public static decimal DecimalValidado()
        {
            decimal aux;
            while (!decimal.TryParse(Console.ReadLine(),out aux))
                Console.WriteLine("Error! Solo puede ser un numero entero o decimal (Tipo de dato decimal)");
            return aux;
        }
        public static double DoubleValidado()
        {
            double aux;
            while (!double.TryParse(Console.ReadLine(),out aux))
                Console.WriteLine("Error! Solo puede ser un numero entero o decimal (Tipo de dato double)");
            return aux;
        }
    }
}
