using System;
namespace prueba
{
    class Prueba4
    {
        public static void P4()
        {
            try
            {
                bool val;
                string name;
                System.Console.WriteLine("digite el nombre del cliente");
                while (true)
                {
                    name = System.Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        System.Console.WriteLine("el valor no es valido");
                    }
                    else
                    {
                        break;
                    }
                }
                double prestamo;
                System.Console.WriteLine("digite el monto del prestamo");
                while (true)
                {
                    val = double.TryParse(Console.ReadLine(), out prestamo);
                    if (!val)
                    {
                        System.Console.WriteLine("dato invalido");
                    }
                    else if (prestamo <= 0)
                    {
                        System.Console.WriteLine("el monto debe ser mayor a 0");
                    }
                    else
                    {
                        break;
                    }
                }
                double TIA;
                System.Console.WriteLine("digite el valor de la tia");
                while (true)
                {
                    val = double.TryParse(Console.ReadLine(), out TIA);
                    if (!val)
                    {
                        System.Console.WriteLine("dato invalido");
                    }
                    else if (TIA < 1 || TIA > 30)
                    {
                        System.Console.WriteLine("el valor debe estar entre 1 y 30");
                    }
                    else
                    {
                        break;
                    }
                }
                int PPM;
                System.Console.WriteLine("digite el plazo del prestamo en meses");
                while (true)
                {
                    val = int.TryParse(Console.ReadLine(), out PPM);
                    if (!val)
                    {
                        System.Console.WriteLine("dato invalido");
                    }
                    else if (PPM <= 0 || PPM > 60)
                    {
                        System.Console.WriteLine("el valor debe estar entre 1 y 60");
                    }
                    else
                    {
                        break;
                    }
                }
                double interes = prestamo * TIA / 100;
                double total = prestamo + interes;
                double pago_mensual = total / PPM;
                System.Console.WriteLine("========REPORTE========");
                System.Console.WriteLine("Cliente: " + name);
                System.Console.WriteLine("Monto del prestamo: " + prestamo);
                System.Console.WriteLine("Tasa de interes: " + TIA + "%");
                System.Console.WriteLine("Plazo del prestamo: " + PPM + " meses");
                System.Console.WriteLine("Total a pagar: " + total);
                System.Console.WriteLine("Pago mensual: " + pago_mensual);
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo ocurrio");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
    }
}