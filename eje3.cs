using System;
namespace clase2
{
    public class E3
    {
        public static void Area()
        {
            bool correcto = false;
            int op = 0;
            bool val;
            try
            {
                do
                {
                    System.Console.WriteLine("escoja una opcion");
                    System.Console.WriteLine("1. Calcular area de un circulo");
                    System.Console.WriteLine("2. Calcular volumen de un cilindro");
                    System.Console.WriteLine("3. Salir");
                    val = int.TryParse(Console.ReadLine(), out op);
                    if (!val)
                    {
                        System.Console.WriteLine("debes ingresar un numero");
                    }
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine("digite el radio del cilindro");
                            double r = 0;
                            do
                            {
                                val = double.TryParse(Console.ReadLine(), out r);
                                if (!val)
                                {
                                    System.Console.WriteLine("debes ingresar un numero");
                                }
                                else if (r <= 0)
                                {
                                    System.Console.WriteLine("debe ser mayor a 0");
                                }
                                else
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
                                val = double.TryParse(Console.ReadLine(), out radio);
                                if (!val)
                                {
                                    System.Console.WriteLine("debes ingresar un numero");
                                }
                                else if (radio <= 0)
                                {
                                    System.Console.WriteLine("debe ser mayor a 0");
                                }
                                else
                                {
                                    System.Console.WriteLine("digite la altura del cilindro");
                                    double altura = 0;
                                    do
                                    {
                                        val = double.TryParse(Console.ReadLine(), out altura);
                                        if (!val)
                                        {
                                            System.Console.WriteLine("debes ingresar un numero");
                                        }
                                        else if (altura <= 0)
                                        {
                                            System.Console.WriteLine("debe ser mayor a 0");
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
                        default:
                            Console.WriteLine("opcion invalida");
                            break;
                    }
                } while (correcto == false);
            }
            catch (Exception)
            {
                System.Console.WriteLine("algo ocurrio");
            }
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