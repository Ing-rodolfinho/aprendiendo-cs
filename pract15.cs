using System;
namespace practica15
{
    public class Pract15
    {
        public static void P15()
        {
            try
            {
                double caja, inventario, bancos, mobiliario, proveedores, prestamos, totalA, totalP, patrimonio;
                bool salida = false;
                string name;
                while (!salida)
                {
                    System.Console.WriteLine("=======NOMBRE DE LA EMPRESA======");
                    name = Console.ReadLine()!;
                    while (true)
                    {
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            System.Console.WriteLine("digite un nombre valido");
                        }
                        else
                        {
                            break;
                        }
                    }
                    System.Console.WriteLine("========DIGITE ACTIVOS========");
                    System.Console.WriteLine("Digite caja: ");
                    caja = Val();
                    System.Console.WriteLine("Digite inventario: ");
                    inventario = Val();
                    System.Console.WriteLine("Digite bancos: ");
                    bancos = Val();
                    System.Console.WriteLine("Digite mobiliario: ");
                    mobiliario = Val();
                    System.Console.WriteLine("=====DIGITE PASIVOS======");
                    System.Console.WriteLine("Digite proveedores");
                    proveedores = Val();
                    System.Console.WriteLine("Digite prestamos");
                    prestamos = Val();
                    totalP = proveedores + prestamos;
                    System.Console.WriteLine("====== RESULTADO ======");
                    totalA = caja + inventario + bancos + mobiliario;
                    patrimonio = totalA - totalP;
                    System.Console.WriteLine($"total activos: {totalA}");
                    System.Console.WriteLine($"total pasivos: {totalP}");
                    System.Console.WriteLine($"patrimonio: {patrimonio}");
                    if (patrimonio < 0)
                    {
                        System.Console.WriteLine("El patrimonio es negativo");
                    }
                    else if (patrimonio > 0)
                    {
                        System.Console.WriteLine("El patrimonio es positivo");
                    }
                    else
                    {
                        System.Console.WriteLine("La empresa esta equilibrada");
                    }
                    salida = true;
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("algo fallo");
            }
        }
        public static double Val()
        {
            double num;
            bool validar;
            while (true)
            {
                validar = double.TryParse(Console.ReadLine(), out num);
                if (!validar)
                {
                    System.Console.WriteLine("digite un valor valido");
                }
                else if (num < 0)
                {
                    System.Console.WriteLine("digite un valor mayor o igual a 0");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}