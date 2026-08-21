using System;
namespace Prac
{
    public class class1
    {
        public static void Clase1()
        {
            double d = 0;
            const int mob = 2;
            const int vehi = 5;
            double vi;
            bool salida = false;
            int op = 0;
            try
            {
                while (!salida)
                {
                    Console.WriteLine("producto a adquirir \n1. Vehiculo \n2. Mobiliario \n3. Salir");
                    op = ValidacionOpcion();
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Digite el precio del vehiculo");
                            vi = ValidacionDouble(3000, 150000);
                            d = vi / vehi;
                            Console.WriteLine("El resultado es: " + d);
                            break;
                        case 2:
                            Console.WriteLine("Digite el precio del mobiliario");
                            vi = ValidacionDouble(1000, 50000);
                            d = vi / mob;
                            Console.WriteLine("El resultado es: " + d);
                            break;
                        case 3:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ALGO OCURRIO");
            }
            finally
            {
                Console.WriteLine("FIN DEL PROGRAMA");
            }
        }
        public static int ValidacionOpcion()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (num < 1 || num > 3)
                {
                    Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else
                {
                    return num;
                }
            }
        }
        public static double ValidacionDouble(double minimo, double maximo)
        {
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double num))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (num < minimo || num > maximo)
                {
                    Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}