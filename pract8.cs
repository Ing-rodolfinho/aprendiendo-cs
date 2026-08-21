using System;

namespace practica7
{
    class Venta_dolar
    {
        public static void Venta_Compra_Dolar()
        {
            int op = 0;
            bool salir = false;
            double d = 0;
            double c = 0;
            while (!salir)
            {
                Console.WriteLine("DIGITE UNA OPCION\n1. Comprar dólares\n2. Vender dólares\n3. Salir");
                op = ValidarOpcion();
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.Write("Digite la cantidad de dólares a comprar: ");
                            d = ValidarCantidad();
                            Console.WriteLine("DEBE PAGAR " + Compra(d, 36.50).ToString() + " córdobas");
                        } while (d <= 0);
                        break;
                    case 2:
                        Console.Write("Digite la cantidad de dólares a vender: ");
                        c = ValidarCantidad();
                        Console.WriteLine("RECIBE " + Venta(c, 36.80).ToString() + " córdobas");
                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar el programa.");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        public static double Compra(double d, double compra)
        {
            return d * compra;
        }

        public static double Venta(double c, double venta)
        {
            return c * venta;
        }

        public static int ValidarOpcion()
        {
            int op;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (op < 1 || op > 3)
                {
                    System.Console.WriteLine("LA OPCION DEBE SER MAYOR A 0 Y MENOR A 4");
                }
                else
                {
                    return op;
                }
            }
        }
        public static int ValidarCantidad()
        {
            int c;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (c < 1 || c > 11000)
                {
                    System.Console.WriteLine("LA CANTIDAD DEBE SER MAYOR A 0 Y MENOR A 11000");
                }
                else
                {
                    return c;
                }
            }
        }

    }
}