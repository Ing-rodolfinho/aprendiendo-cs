using System;
namespace practica14
{
    public class Pract14
    {
        public static void Main(string[] args)
        {
            try
            {
                bool salida = false;
                bool validar;
                double ingresos = 0;
                double gastosdealquiler = 0;
                double gastosdesalarios = 0;
                double gastosdeservicios = 0;
                double otrosgastos = 0;
                double totalgastos = 0;
                string nombreEmpresa = "";
                while (!salida)
                {
                    int op;
                    System.Console.WriteLine("========MENU========");
                    System.Console.WriteLine("1. Operar estados financieros");
                    System.Console.WriteLine("2. Mostrar Estados financieros");
                    System.Console.WriteLine("3. Salir");
                    while (true)
                    {
                        validar = int.TryParse(Console.ReadLine(), out op);
                        if (!validar)
                        {
                            System.Console.WriteLine("tipo de dato invalido");
                        }
                        else if (op < 1 || op > 3)
                        {
                            System.Console.WriteLine("opcion invalida");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine("=====NOMBRE DE LA EMPRESA======");
                            while (true)
                            {
                                nombreEmpresa = Console.ReadLine()!;
                                if (string.IsNullOrWhiteSpace(nombreEmpresa))
                                {
                                    System.Console.WriteLine("nombre invalido");
                                    continue;
                                }
                                else
                                {
                                    System.Console.WriteLine("Nombre registrado exitosamente");
                                    break;
                                }
                            }
                            System.Console.WriteLine("====== INGRESOS ======");
                            while (true)
                            {
                                validar = double.TryParse(Console.ReadLine(), out ingresos);
                                if (!validar)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (ingresos < 0)
                                {
                                    System.Console.WriteLine("ingreso invalido");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            System.Console.WriteLine("=====GASTOS DE ALQUILER====");
                            while (true)
                            {
                                validar = double.TryParse(Console.ReadLine(), out gastosdealquiler);
                                if (!validar)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (gastosdealquiler < 0)
                                {
                                    System.Console.WriteLine("gastos de alquiler invalido");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            System.Console.WriteLine("=====GASTOS DE SALARIOS====");
                            while (true)
                            {
                                validar = double.TryParse(Console.ReadLine(), out gastosdesalarios);
                                if (!validar)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (gastosdesalarios < 0)
                                {
                                    System.Console.WriteLine("gastos de salarios invalido");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            System.Console.WriteLine("=====GASTOS DE SERVICIOS====");
                            while (true)
                            {
                                validar = double.TryParse(Console.ReadLine(), out gastosdeservicios);
                                if (!validar)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (gastosdeservicios < 0)
                                {
                                    System.Console.WriteLine("gastos de servicios invalido");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            System.Console.WriteLine("=====OTROS GASTOS====");
                            while (true)
                            {
                                validar = double.TryParse(Console.ReadLine(), out otrosgastos);
                                if (!validar)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (otrosgastos < 0)
                                {
                                    System.Console.WriteLine("otros gastos invalido");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            totalgastos = gastosdealquiler + gastosdesalarios + gastosdeservicios + otrosgastos;
                            System.Console.WriteLine("TOTAL GASTOS: " + totalgastos);
                            break;
                        case 2:
                            double utilidadneta = ingresos - totalgastos;
                            MostrarEstadosFinancieros(ingresos, gastosdealquiler, gastosdesalarios, gastosdeservicios, otrosgastos, totalgastos, utilidadneta, nombreEmpresa);
                            break;
                        case 3:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("algo salio mal");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
        public static void MostrarEstadosFinancieros(double ingresos, double gastosdealquiler, double gastosdesalarios, double gastosdeservicios, double otrosgastos, double totalgastos, double utilidadneta, string nombre)
        {
            System.Console.WriteLine("=====ESTADOS FINANCIEROS=====");
            System.Console.WriteLine("NOMBRE DE LA EMPRESA: " + nombre);
            System.Console.WriteLine("Ingresos: " + ingresos);
            System.Console.WriteLine("Gastos de alquiler: " + gastosdealquiler);
            System.Console.WriteLine("Gastos de salarios: " + gastosdesalarios);
            System.Console.WriteLine("Gastos de servicios: " + gastosdeservicios);
            System.Console.WriteLine("Otros gastos: " + otrosgastos);
            System.Console.WriteLine("Total gastos: " + totalgastos);
            if (utilidadneta > 0)
            {
                System.Console.WriteLine("La empresa obtuvo ganancias");
                System.Console.WriteLine("Utilidad neta: " + utilidadneta);
            }
            else if (utilidadneta == 0)
            {
                System.Console.WriteLine("La empresa no obtuvo ganancias ni perdidas");
            }
            else
            {
                System.Console.WriteLine("La empresa obtuvo perdidas");
                System.Console.WriteLine("Utilidad neta: " + utilidadneta);
            }
        }
    }
}