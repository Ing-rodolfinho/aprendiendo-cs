using System;

namespace Compra
{
    public class Com
    {
        public static void Comp()
        {
            double vi;
            double d;
            const int mob = 2;
            const int veh = 5;
            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("\n¿Qué desea adquirir?");
                Console.WriteLine("1. Mobiliario");
                Console.WriteLine("2. Vehículo");
                Console.WriteLine("3. Salir");
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Formato inválido.");
                    continue;
                }
                switch (op)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Digite el precio del mobiliario:");
                            if (double.TryParse(Console.ReadLine(), out vi))
                            {
                                if (vi >= 30 && vi <= 800)
                                {
                                    d = vi / mob;
                                    Console.WriteLine("Precio de depreciación: " + d);
                                }
                                else
                                {
                                    Console.WriteLine("El precio debe estar entre 30 y 800.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Formato inválido.");
                                vi = 0;
                            }
                        } while (vi < 30 || vi > 800);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Digite el precio del vehículo:");
                            if (double.TryParse(Console.ReadLine(), out vi))
                            {
                                if (vi >= 3000 && vi <= 150000)
                                {
                                    d = vi / veh;
                                    Console.WriteLine("Precio de depreciación: " + d);
                                }
                                else
                                {
                                    Console.WriteLine("El precio debe estar entre 3000 y 150000.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Formato inválido.");
                                vi = 0;
                            }
                        } while (vi < 3000 || vi > 150000);
                        break;
                    case 3:
                        Console.WriteLine("programa finalizado");
                        break;
                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                }
            }
        }
    }
}