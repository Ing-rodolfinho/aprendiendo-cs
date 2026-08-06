using System;
namespace Prac
{
    public class class1
    {
        public static void Clase1()
        {
            double d = 0;
            const int mob = 2;
            const int vehi = 5;
            double vi;
            bool correcto = false;
            bool correcto2 = false;
            int op = 0;
            while (correcto2 == false)
            {
                try
                {
                    Console.WriteLine("producto a adquirir");
                    Console.WriteLine("1.vehiculo");
                    Console.WriteLine("2.mobiliario");
                    op = Convert.ToInt32(Console.ReadLine());
                    correcto2 = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ocurrio algo inesperado");
                }
            }
            while (correcto == false)
            {
                try
                {
                    switch (op)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("digite el precio del vehiculo");
                                vi = Convert.ToDouble(Console.ReadLine());
                                if (vi >= 3000 && vi <= 150000)
                                {
                                    d = (double)vi / vehi;
                                    System.Console.WriteLine(d);
                                }
                                else
                                {
                                    System.Console.WriteLine("precio invalido");
                                }
                            } while (vi < 3000 || vi > 150000);
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("digite el precio del mobiliario");
                                vi = Convert.ToDouble(Console.ReadLine());
                                if (vi >= 1000 && vi <= 50000)
                                {
                                    d = (double)vi / mob;
                                    System.Console.WriteLine(d);
                                }
                                else
                                {
                                    System.Console.WriteLine("precio invalido");
                                }
                            } while (vi < 1000 || vi > 50000);
                            break;
                        default:
                            System.Console.WriteLine("opcion invalida");
                            break;
                    }
                    correcto = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ocurrio algo inesperado");
                }
            }
        }
    }
}