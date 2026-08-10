using System;
namespace prueba
{
    public class Prueba3
    {
        public static void P3()
        {
            try
            {
                bool val;
                string nombre;
                System.Console.WriteLine("Digite el nombre del cliente");
                while (true)
                {
                    nombre = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        System.Console.WriteLine("debe digitar un nombre valido");
                    }
                    else
                    {
                        break;
                    }
                }
                string NameProducto;
                System.Console.WriteLine("Digite el nombre del producto");
                while (true)
                {
                    NameProducto = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(NameProducto))
                    {
                        System.Console.WriteLine("debe digitar un nombre valido");
                    }
                    else
                    {
                        break;
                    }
                }
                double precio;
                System.Console.WriteLine("Digite el precio del producto");
                while (true)
                {
                    val = double.TryParse(Console.ReadLine(), out precio);
                    if (!val)
                    {
                        System.Console.WriteLine("debe digitar un numero valido");
                    }
                    else if (precio <= 0)
                    {
                        System.Console.WriteLine("el precio debe ser mayor a 0");
                    }
                    else
                    {
                        break;
                    }
                }
                int unidades;
                System.Console.WriteLine("Digite la cantidad de unidades");
                while (true)
                {
                    val = int.TryParse(Console.ReadLine(), out unidades);
                    if (!val)
                    {
                        System.Console.WriteLine("debe digitar un numero valido");
                    }
                    else if (unidades <= 0 || unidades > 100)
                    {
                        System.Console.WriteLine("la cantidad debe estar entre 1 y 100");
                    }
                    else
                    {
                        break;
                    }
                }
                int cuotas;
                System.Console.WriteLine("digite la cantidad de cuotas");
                while (true)
                {
                    val = int.TryParse(Console.ReadLine(), out cuotas);
                    if (!val)
                    {
                        System.Console.WriteLine("debe digitar un numero valido");
                    }
                    else if (cuotas <= 0 || cuotas > 24)
                    {
                        System.Console.WriteLine("la cantidad de cuotas debe estar entre 1 y 24");
                    }
                    else
                    {
                        break;
                    }
                }
                double subtotal = precio * unidades;
                double impuesto = subtotal * 0.15;
                double total = subtotal + impuesto;
                double cuota = total / cuotas;
                System.Console.WriteLine("==========Reporte==========");
                System.Console.WriteLine("Cliente: " + nombre);
                System.Console.WriteLine("Producto: " + NameProducto);
                System.Console.WriteLine("Precio: " + precio);
                System.Console.WriteLine("Unidades: " + unidades);
                System.Console.WriteLine("Subtotal: " + subtotal);
                System.Console.WriteLine("impuesto: 15%");
                System.Console.WriteLine("Monto del Impuesto: " + impuesto);
                System.Console.WriteLine("Total a Pagar: " + total);
                System.Console.WriteLine("Cantidad de cuotas: " + cuotas);
                System.Console.WriteLine("Monto de la cuota: " + cuota);
                System.Console.WriteLine("");
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