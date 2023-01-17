namespace Entornos
{
    class Menus
    {
        static void Main(string[] args)
        {
            int opciones = 0;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Array");
                Console.WriteLine("2. Numero");
                Console.WriteLine("3. String");
                Console.WriteLine("4. Decimales");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opcion...");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        Menus2.Arrays();
                        break;
                    case 2:
                        Menus2.Numero();
                        break;
                    case 3:
                        Menus2.String();
                        break;
                    case 4:
                        Menus2.Decimales();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opciones != 5);
        }
    }
    class Menus2
    {
        public static void Arrays()
        {
            int opciones = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Menu de Array:");
                Console.WriteLine("1. Calcular Maximo");
                Console.WriteLine("2. Calcular Minimo");
                Console.WriteLine("3. Calcular la mediana");
                Console.WriteLine("4. Calcular la media");
                Console.WriteLine("5. Ordenar de mayor a menor");
                Console.WriteLine("6. Desviacion tipica");
                Console.WriteLine("7.Binarizar");
                Console.WriteLine("8. Atras");
                Console.Write("Elige una opcion...");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            } while (opciones != 8);
        }
        public static void Numero()
        {
            int opciones = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Menu de Array:");
                Console.WriteLine("1. Comprobar si es primo");
                Console.WriteLine("2. Calcular factorial");
                Console.WriteLine("3. De segundos a Horas, mimutos y segundos");
                Console.WriteLine("4. Numeros de Pell");
                Console.WriteLine("5. Comprobar si es un numero de Armstrong");
                Console.WriteLine("6. Comprobar si todos los digitos son diferentes");
                Console.WriteLine("7.Atras");
                Console.Write("Elige una opcion...");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Entornos.Numero.Pell();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            } while (opciones != 7);
        }
        public static void String()
        {
            int opciones = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Menu de Array:");
                Console.WriteLine("1. Saber si es palindromo");
                Console.WriteLine("2. Mayusculas y minusculas");
                Console.WriteLine("3. Ocurrencias de una letra");
                Console.WriteLine("4. Repetir un string");
                Console.WriteLine("5. Repetir caracteres");
                Console.WriteLine("6. Eliminar cadena");
                Console.WriteLine("7.Atras");
                Console.Write("Elige una opcion...");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            } while (opciones != 7);
        }
        public static void Decimales()
        {
            int opciones = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Menu de Array:");
                Console.WriteLine("1. Redondear al alza");
                Console.WriteLine("2. Eliminar decimales");
                Console.WriteLine("3. Ecuaciones de 2º");
                Console.WriteLine("4. Atras");
                Console.Write("Elige una opcion...");
                opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            } while (opciones != 4);
        }
    }
}