using System;
using System.Linq.Expressions;
using System.Net;
using System.Security.Cryptography.X509Certificates;
namespace prueba
{
    public class Prueba2
    {
        public static void P2()
        {
            try
            {
                string nombre;
                bool val;
                System.Console.WriteLine("digite su nombre");
                while (true)
                {
                    nombre = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        System.Console.WriteLine("debe digitar un nombre");
                    }
                    else
                    {
                        break;
                    }
                }
                int edad;
                while (true)
                {
                    System.Console.WriteLine("Digite su edad");
                    val = int.TryParse(Console.ReadLine(), out edad);
                    if (!val)
                    {
                        System.Console.WriteLine("digite un numero valido");
                    }
                    else if (edad < 18 || edad > 100)
                    {
                        System.Console.WriteLine("la edad debe estar entre 18 y 100");
                    }
                    else
                    {
                        break;
                    }
                }
                int cantidad;
                while (true)
                {
                    System.Console.WriteLine("digite la cantidad de productos");
                    val = int.TryParse(Console.ReadLine(), out cantidad);
                    if (!val)
                    {
                        System.Console.WriteLine("digite un numero valido");
                    }
                    else if (cantidad < 1 || cantidad > 20)
                    {
                        System.Console.WriteLine("la cantidad debe estar entre 1 y 20");
                    }
                    else
                    {
                        break;
                    }
                }
                double total = 0;
                double[] precio = new double[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    while (true)
                    {
                        System.Console.WriteLine("digite el precio del producto " + (i + 1));
                        val = double.TryParse(Console.ReadLine(), out precio[i]);
                        if (!val)
                        {
                            System.Console.WriteLine("digite un numero valido");
                        }
                        else if (precio[i] < 0)
                        {
                            System.Console.WriteLine("el precio debe ser mayor a 0");
                        }
                        else
                        {
                            total += precio[i];
                            break;
                        }
                    }
                }
                double Descuento;
                int op;
                while (true)
                {
                    System.Console.WriteLine("Digite el metodo de pago");
                    System.Console.WriteLine("1. Efectivo");
                    System.Console.WriteLine("2. Tarjeta");
                    System.Console.WriteLine("3. Transferencia");
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);
                        if (!val)
                        {
                            System.Console.WriteLine("digite un numero valido");
                        }
                        else if (op < 1 || op > 3)
                        {
                            System.Console.WriteLine("el metodo de pago debe estar entre 1 y 3");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine("==========Factura==========");
                            Descuento = 0.10;
                            total = total - (total * Descuento);
                            System.Console.WriteLine("Nombre: " + nombre);
                            System.Console.WriteLine("Edad: " + edad);
                            System.Console.WriteLine("Cantidad de productos: " + cantidad);
                            System.Console.WriteLine("Precio de los productos: ");
                            for (int i = 0; i < cantidad; i++)
                            {
                                System.Console.WriteLine("producto " + (i + 1) + ": " + precio[i]);
                            }
                            System.Console.WriteLine("descuento: 10%");
                            System.Console.WriteLine("Total: " + total);
                            break;
                        case 2:
                            Descuento = 0.05;
                            total = total - (total * Descuento);
                            System.Console.WriteLine("==========Factura==========");
                            System.Console.WriteLine("Nombre: " + nombre);
                            System.Console.WriteLine("Edad: " + edad);
                            System.Console.WriteLine("Cantidad de productos: " + cantidad);
                            System.Console.WriteLine("Precio de los productos: ");
                            for (int i = 0; i < cantidad; i++)
                            {
                                System.Console.WriteLine("producto " + (i + 1) + ": " + precio[i]);
                            }
                            System.Console.WriteLine("descuento: 5%");
                            System.Console.WriteLine("Total: " + total);
                            break;
                        case 3:
                            Descuento = 0;
                            System.Console.WriteLine("==========Factura==========");
                            System.Console.WriteLine("Nombre: " + nombre);
                            System.Console.WriteLine("Edad: " + edad);
                            System.Console.WriteLine("Cantidad de productos: " + cantidad);
                            System.Console.WriteLine("Precio de los productos: ");
                            for (int i = 0; i < cantidad; i++)
                            {
                                System.Console.WriteLine("producto " + (i + 1) + ": " + precio[i]);
                            }
                            System.Console.WriteLine("descuento: 0%");
                            System.Console.WriteLine("Total: " + total);
                            break;
                    }
                    break;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Ha ocurrido un error");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
    }
}