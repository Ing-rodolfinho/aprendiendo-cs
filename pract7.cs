using System;
namespace fisic
{
    class Fisica
    {
        public static void Fisi()
        {
            int op = 0;
            bool salida = false;
            while (!salida)
            {
                System.Console.WriteLine("Calcular MRU\n1. Calcular distancia\n2. Calcular tiempo\n3. Calcular velocidad\n4. Salir");
                op = ValidarOpcion();
                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("ingrese la velocidad");
                        double v1 = ValidarDouble();
                        System.Console.WriteLine("Ingrese el tiempo");
                        double t1 = ValidarDouble();
                        System.Console.WriteLine("la distancia es: " + DMru(v1, t1));
                        break;
                    case 2:
                        System.Console.WriteLine("ingrese la velocidad");
                        double v2 = ValidarDouble();
                        System.Console.WriteLine("Ingrese la distancia");
                        double d2 = ValidarDouble();
                        System.Console.WriteLine("el tiempo es: " + TMru(v2, d2));
                        break;
                    case 3:
                        System.Console.WriteLine("ingrese la distancia");
                        double d3 = ValidarDouble();
                        System.Console.WriteLine("Ingrese el tiempo");
                        double t3 = ValidarDouble();
                        System.Console.WriteLine("la velocidad es: " + VMru(d3, t3));
                        break;
                    case 4:
                        salida = true;
                        break;
                }
            }
        }
        public static int ValidarOpcion()
        {
            int op;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    System.Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (op < 1 || op > 4)
                {
                    System.Console.WriteLine("EL NUMERO DEBE ESTAR ENTRE 1 y 4");
                }
                else
                {
                    return op;
                }
            }
        }
        public static double ValidarDouble()
        {
            double num;
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (num <= 0)
                {
                    Console.WriteLine("EL NUMERO DEBE SER MAYOR A 0");
                }
                else
                {
                    return num;
                }
            }
        }
        public static double DMru(double v, double t)
        {
            return v * t;
        }
        public static double TMru(double v, double d)
        {
            return d / v;
        }
        public static double VMru(double d, double t)
        {
            return d / t;
        }
    }
}