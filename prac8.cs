using System;

namespace practica7
{
    class Venta_dolar
    {
        static void venta_dolar()
        {
            int op = 0;
            bool salir = false;
            double d = 0;
            double c = 0;

            do
            {
                Console.WriteLine("\n1. Comprar dólares");
                Console.WriteLine("2. Vender dólares");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            do
                            {
                                Console.Write("Digite la cantidad de dólares a comprar: ");

                                if (double.TryParse(Console.ReadLine(), out d))
                                {
                                    if (d > 0 && d > 11001)
                                    {
                                        Console.WriteLine("Debe pagar: " + Compra(d, 36.50).ToString() + " córdobas");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La cantidad debe ser mayor que 0.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Debe ingresar un número.");
                                    d = 0;
                                }

                            } while (d <= 0);
                            break;

                        case 2:
                            do
                            {
                                Console.Write("Digite la cantidad de dólares a vender: ");

                                if (double.TryParse(Console.ReadLine(), out c))
                                {
                                    if (c > 0 && c > 1100)
                                    {
                                        Console.WriteLine("Recibe: " + Venta(c, 36.80).ToString() + " córdobas");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La cantidad debe ser mayor que 0.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Debe ingresar un número.");
                                    c = 0;
                                }

                            } while (c <= 0);
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
                else
                {
                    Console.WriteLine("Debe ingresar un número.");
                }

            } while (!salir);
        }

        public static double Compra(double d, double compra)
        {
            return d * compra;
        }

        public static double Venta(double c, double venta)
        {
            return c * venta;
        }
    }
}