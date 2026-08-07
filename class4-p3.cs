using System;
namespace clase2
{
    public class Practica3
    {
        public static void Area()
        {
            bool correcto = false;
            int op = 0;
            do
            {
                System.Console.WriteLine("escoja una opcion");
                System.Console.WriteLine("1. Calcular area de un circulo");
                System.Console.WriteLine("2. Calcular volumen de un cilindro");
                System.Console.WriteLine("3. Salir");
                try
                {
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op < 1 || op > 3)
                    {
                        System.Console.WriteLine("opcion invalida");
                    }
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Algo ocurrio");
                }

                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("digite el radio del cilindro");
                        double r = 0;
                        do
                        {
                            try
                            {
                                r = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                System.Console.WriteLine("algo ocurrio");
                            }
                            if (r < 0)
                            {
                                System.Console.WriteLine("radio invalido");
                            }
                            else if (r > 0)
                            {
                                System.Console.WriteLine("el area del circulo es: " + Area(r));
                            }
                        } while (r <= 0);
                        break;
                    case 2:
                        System.Console.WriteLine("digite el radio del cilindro");
                        double radio = 0;
                        do
                        {
                            try
                            {
                                radio = Convert.ToDouble(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                System.Console.WriteLine("algo ocurrio");
                            }
                            if (radio < 0)
                            {
                                System.Console.WriteLine("radio invalido");
                            }
                            else if (radio > 0)
                            {
                                System.Console.WriteLine("digite la altura del cilindro");
                                double altura = 0;
                                do
                                {


                                    try
                                    {
                                        altura = Convert.ToDouble(Console.ReadLine());
                                    }
                                    catch (Exception)
                                    {
                                        System.Console.WriteLine("algo ocurrio");
                                    }
                                    if (altura <= 0)
                                    {
                                        System.Console.WriteLine("altura invalida");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("el volumen del cilindro es: " + Volumen(radio, altura));
                                    }
                                } while (altura <= 0);
                            }
                        } while (radio <= 0);
                        break;
                    case 3:
                        correcto = true;
                        break;
                }
            } while (correcto == false);
        }
        public static double Area(double radio)
        {
            return Math.PI * radio * radio;
        }
        public static double Volumen(double radio, double altura)
        {
            return Math.PI * radio * radio * altura;
        }
    }
}