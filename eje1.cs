using System;
namespace Figiuras
{
    public class E1
    {
        public static void Clase5plusultra()
        {
            int op = 0;
            while (true)
            {
                Menu();
                try
                {
                    Console.Write("opción: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            double b = 0;
                            double a = 0;
                            System.Console.WriteLine("Digite la base");
                            while (b <= 0)
                            {
                                if (!double.TryParse(Console.ReadLine(), out b))
                                {
                                    System.Console.WriteLine("tienes que ingresar un numero ");
                                }
                                else if (b <= 0)
                                {
                                    System.Console.WriteLine("tiene que ser mayor a 0");
                                }
                            }
                            System.Console.WriteLine("Digite la altura");
                            while (a <= 0)
                            {
                                if (!double.TryParse(Console.ReadLine(), out a))
                                {
                                    System.Console.WriteLine("tienes que ingresar un numero ");
                                }
                                else if (a <= 0)
                                {
                                    System.Console.WriteLine("tiene que ser mayor a 0");
                                }
                            }
                            double R = Triangulo(b, a);
                            System.Console.WriteLine("El area del triangulo es: " + R);
                            break;
                        case 2:
                            double l = 0;
                            System.Console.WriteLine("Digite la Lngitud");
                            while (l <= 0)
                            {
                                if (!double.TryParse(Console.ReadLine(), out l))
                                {
                                    System.Console.WriteLine("tienes que ingresar un numero ");
                                }
                                else if (l <= 0)
                                {
                                    System.Console.WriteLine("tiene que ser mayor a 0");
                                }
                            }
                            double c = Cuadrado(l);
                            System.Console.WriteLine("El area del cuadrado es: " + c);
                            break;
                        case 3:
                            double ba = 0;
                            double al = 0;
                            System.Console.WriteLine("Digite la base");
                            while (ba <= 0)
                            {
                                if (!double.TryParse(Console.ReadLine(), out ba))
                                {
                                    System.Console.WriteLine("tienes que ingresar un numero ");
                                }
                                else if (ba <= 0)
                                {
                                    System.Console.WriteLine("tiene que ser mayor a 0");
                                }
                            }
                            System.Console.WriteLine("Digite la altura");
                            while (al <= 0)
                            {
                                if (!double.TryParse(Console.ReadLine(), out al))
                                {
                                    System.Console.WriteLine("tienes que ingresar un numero ");
                                }
                                else if (al <= 0)
                                {
                                    System.Console.WriteLine("tiene que ser mayor a 0");
                                }
                            }
                            double J = Rectangulo(ba, al);
                            System.Console.WriteLine("El area del rectangulo es: " + J);
                            break;
                        case 4:
                            Console.WriteLine("saliendo...");
                            return;
                        default:
                            System.Console.WriteLine("opcion invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("debes ingresar un numero");
                }
                catch (Exception)
                {
                    System.Console.WriteLine("algo ocurrio");
                }
            }
        }
        public static void Menu()
        {
            System.Console.WriteLine("seleccione una opcion");
            System.Console.WriteLine("1. Area del triangulo");
            System.Console.WriteLine("2. Area del cuadrado");
            System.Console.WriteLine("3. Area del rectangulo");
            System.Console.WriteLine("4. salir");
        }
        public static double Triangulo(double Base, double Altura)
        {
            return (Base * Altura) / 2;
        }
        public static double Cuadrado(double longitud)
        {
            return longitud * longitud;
        }
        public static double Rectangulo(double Base, double Altura)
        {
            return Base * Altura;
        }
    }
}