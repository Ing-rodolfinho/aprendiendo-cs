using System;
namespace fisic
{
    class Fisica
    {
        static void Fisi()
        {
            int op = 0;
            bool correcto = false;
            System.Console.WriteLine("Calcular MRU");
            System.Console.WriteLine("1. Calcular distancia");
            System.Console.WriteLine("2. Calcular tiempo");
            System.Console.WriteLine("3. Calcular velocidad");
            System.Console.WriteLine("4. Salir");
            do
            {
                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:

                            System.Console.WriteLine("ingrese la velocidad");
                            double v;
                            do
                            {
                                if (double.TryParse(Console.ReadLine(), out v))
                                {
                                    System.Console.WriteLine("Ingrese el tiempo");
                                    do
                                    {
                                        if (double.TryParse(Console.ReadLine(), out double t))
                                        {
                                            System.Console.WriteLine("la distancia es: " + DMru(v, t));
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("tiene que ingresar un numero");
                                        }
                                    } while (v <= 0);
                                }
                                else
                                {
                                    System.Console.WriteLine("tiene que ingresar un numero");
                                }
                            } while (v <= 0);
                            break;
                        case 2:
                            System.Console.WriteLine("ingrese la velocidad");
                            do
                            {
                                if (double.TryParse(Console.ReadLine(), out v))
                                {
                                    System.Console.WriteLine("Ingrese el tiempo");
                                    do
                                    {
                                        if (double.TryParse(Console.ReadLine(), out double t))
                                        {
                                            System.Console.WriteLine("la distancia es: " + DMru(v, t));
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("tiene que ingresar un numero");
                                        }
                                    } while (v <= 0);
                                }
                                else
                                {
                                    System.Console.WriteLine("tiene que ingresar un numero");
                                }
                            } while (v <= 0);
                            break;
                        case 3:
                            System.Console.WriteLine("ingrese la distancia");
                            do
                            {
                                if (double.TryParse(Console.ReadLine(), out v))
                                {
                                    System.Console.WriteLine("Ingrese el tiempo");
                                    do
                                    {
                                        if (double.TryParse(Console.ReadLine(), out double t))
                                        {
                                            System.Console.WriteLine("la distancia es: " + DMru(v, t));
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("tiene que ingresar un numero");
                                        }
                                    } while (v <= 0);
                                }
                                else
                                {
                                    System.Console.WriteLine("tiene que ingresar un numero");
                                }
                            } while (v <= 0);
                            break;
                        case 4:
                            correcto = true;
                            break;
                    }
                }
                else if (op < 1 || op > 4)
                {
                    System.Console.WriteLine("opcion invalida");
                }
                else
                {
                    System.Console.WriteLine("debe ingresar un numero");
                }

            } while (correcto != true);
        }
        public static double DMru(double v, double t)
        {
            return v * t;
        }
        public static double TMru(double v, double d)
        {
            return d / v;
        }
        public static double VMru(double d, double t)
        {
            return d / t;
        }
    }
}