using System;
namespace Clep
{
    class Clase2
    {
        public static void CL()
        {
            double valor, d;
            int tb;
            try
            {
                Menu();
                do
                {
                    System.Console.WriteLine("Selecciones su opcion");
                    tb = Convert.ToInt32(Console.ReadLine());
                } while (tb < 1 || tb > 2);
                switch (tb)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("digite el valor del vehiculo");
                            valor = Convert.ToDouble(Console.ReadLine());
                        } while (valor < 3000 || valor > 150000);
                        d = CDV(valor);
                        Console.WriteLine("el valor es: " + d);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("digite el valor del vehiculo");
                            valor = Convert.ToDouble(Console.ReadLine());
                        } while (valor < 30 || valor > 800);
                        d = CDM(valor);
                        Console.WriteLine("el valor es: " + d);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("No se admiten letras");
            }
        }
        public static void Menu()
        {
            System.Console.WriteLine("\t 1= vehculo 2 = Mobiliario");
        }
        public static double CDV(double valor_vehi)
        {
            return valor_vehi / 5;
        }
        public static double CDM(double valor_mob)
        {
            return valor_mob / 2;
        }
    }
}