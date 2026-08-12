using System;

namespace practica13
{
    public class Pract13
    {
        public static void P13()
        {
            bool val;
            bool salida = false;

            double totalV = 0;
            double totalD = 0;
            double caja = 0;

            int ventas = 0;
            int devoluciones = 0;

            try
            {
                while (!salida)
                {
                    int op;

                    System.Console.WriteLine("======= CAJA REGISTRADORA ========");
                    System.Console.WriteLine("1. Registrar venta");
                    System.Console.WriteLine("2. Registrar devolución");
                    System.Console.WriteLine("3. Mostrar total vendido");
                    System.Console.WriteLine("4. Mostrar información");
                    System.Console.WriteLine("5. Salir");

                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);

                        if (!val)
                        {
                            System.Console.WriteLine("Tipo de dato inválido");
                        }
                        else if (op < 1 || op > 5)
                        {
                            System.Console.WriteLine("Opción inválida");
                        }
                        else
                        {
                            break;
                        }
                    }

                    switch (op)
                    {
                        case 1:
                            double precio = 0;

                            System.Console.WriteLine("========= DIGITE EL PRECIO =========");

                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out precio);

                                if (!val)
                                {
                                    System.Console.WriteLine("Tipo de dato inválido");
                                }
                                else if (precio <= 0)
                                {
                                    System.Console.WriteLine("Precio inválido");
                                }
                                else
                                {
                                    totalV += precio;
                                    caja += precio;
                                    ventas++;

                                    System.Console.WriteLine("Venta registrada exitosamente");
                                    break;
                                }
                            }

                            break;

                        case 2:
                            double devol = 0;

                            if (caja == 0)
                            {
                                System.Console.WriteLine("No hay dinero disponible en caja");
                                break;
                            }

                            System.Console.WriteLine("========= DIGITE LA DEVOLUCIÓN =========");

                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out devol);

                                if (!val)
                                {
                                    System.Console.WriteLine("Tipo de dato inválido");
                                }
                                else if (devol <= 0)
                                {
                                    System.Console.WriteLine("Devolución inválida");
                                }
                                else if (devol > caja)
                                {
                                    System.Console.WriteLine("Dinero insuficiente en caja");
                                    continue;
                                }
                                else
                                {
                                    totalD += devol;
                                    caja -= devol;
                                    devoluciones++;

                                    System.Console.WriteLine("Devolución registrada exitosamente");
                                    break;
                                }
                            }

                            break;

                        case 3:
                            MostrarTotalVendido(totalV);
                            break;

                        case 4:
                            MostrarInformacion(
                                totalD,
                                totalV,
                                caja,
                                ventas,
                                devoluciones
                            );
                            break;

                        case 5:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo salió mal");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }

        public static void MostrarTotalVendido(double totalV)
        {
            System.Console.WriteLine("=========== TOTAL VENDIDO ===========");
            System.Console.WriteLine("El total vendido es: " + totalV);
            System.Console.WriteLine("--------------------------------------");
        }
        public static void MostrarInformacion(
            double totalD,
            double totalV,
            double caja,
            int ventas,
            int devoluciones)
        {
            System.Console.WriteLine("=========== INFORMACIÓN ===========");
            System.Console.WriteLine("Total de ventas: " + totalV);
            System.Console.WriteLine("Total de devoluciones: " + totalD);
            System.Console.WriteLine("Dinero en caja: " + caja);
            System.Console.WriteLine("Cantidad de ventas: " + ventas);
            System.Console.WriteLine("Cantidad de devoluciones: " + devoluciones);
            System.Console.WriteLine("------------------------------------");
        }
    }
}
