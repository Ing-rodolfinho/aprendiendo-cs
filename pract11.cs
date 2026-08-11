using System;
namespace Practica11
{
    public class Pract11
    {
        public static void P11()
        {
            try
            {
                double SumaPasivo = 0, SumaActivo = 0;
                bool val;
                bool salida = false;
                while (!salida)
                {
                    int op;
                    System.Console.WriteLine("=========Digite un aopcion=========");
                    System.Console.WriteLine("1. Registar Pasivo");
                    System.Console.WriteLine("2. Registrar Activo");
                    System.Console.WriteLine("3. Mostrar Patrimonio");
                    System.Console.WriteLine("4. Mostrar informacion");
                    System.Console.WriteLine("5. Salir");
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);
                        if (!val)
                        {
                            System.Console.WriteLine("tipo de dato incorrecto");
                        }
                        else if (op < 1 || op > 5)
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
                            System.Console.WriteLine("Digite el valor total del pasivo");
                            double pasivo;
                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out pasivo);
                                if (!val)
                                {
                                    System.Console.WriteLine("tipo de dato incorrecto");
                                }
                                else if (pasivo < 1)
                                {
                                    System.Console.WriteLine("pasivo invalido");
                                }
                                else
                                {
                                    SumaPasivo += pasivo;
                                    System.Console.WriteLine("pasivo registrado exitosamente");
                                    break;
                                }
                            }
                            break;
                        case 2:
                            System.Console.WriteLine("Digite el valor del activo");
                            double activo;
                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out activo);
                                if (!val)
                                {
                                    System.Console.WriteLine("tipo de dato incorrecto");
                                }
                                else if (activo < 1)
                                {
                                    System.Console.WriteLine("activo invalido");
                                }
                                else
                                {
                                    SumaActivo += activo;
                                    System.Console.WriteLine("activo registrado exitosamente");
                                    break;
                                }
                            }
                            break;
                        case 3:
                            MostrarPatrimonio(SumaPasivo, SumaActivo);
                            break;
                        case 4:
                            Mostrar(SumaPasivo, SumaActivo);
                            break;
                        case 5:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo paso");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
        public static void Mostrar(double pasivo, double activo)
        {
            System.Console.WriteLine("===========Informacion===========");
            System.Console.WriteLine("La suma de los pasivos es: " + pasivo);
            System.Console.WriteLine("La suma de los activos es: " + activo);
            System.Console.WriteLine("---------------------------------");
        }
        public static void MostrarPatrimonio(double pasivo, double activo)
        {
            double patrimonio = activo - pasivo;
            System.Console.WriteLine("===========Informacion===========");
            System.Console.WriteLine("El patrimonio es: " + patrimonio);
            System.Console.WriteLine("---------------------------------");
        }
    }
}