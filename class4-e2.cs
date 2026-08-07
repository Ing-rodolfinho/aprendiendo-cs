using System;
namespace clase2
{
    public class Practica2
    {
        public static void Iva1()
        {
            double iv = 1;
            double n;
            System.Console.WriteLine("costo de total de los productos");
            do
            {
                double.TryParse(Console.ReadLine(), out n);
                if (n > 0)
                {
                    System.Console.WriteLine("por favor digite el iva");
                    do
                    {

                        if (double.TryParse(Console.ReadLine(), out iv) && iv >= 0)
                        {
                            System.Console.WriteLine("el costo total con iva es: " + Iva(n, iv));
                        }
                        else if (iv < 0)
                        {
                            System.Console.WriteLine("por favor digite un iva valido (mayor o igual a 0)");
                        }
                        else
                        {
                            System.Console.WriteLine("por favor digite un numero");
                        }
                    } while (iv < 0);
                }
                else if (n < 0)
                {
                    System.Console.WriteLine("por favor digite un costo valido ( mayor o igual a 0)");
                }
                else
                {
                    System.Console.WriteLine("por favor digite un numero");
                }
            } while (n <= 0);
        }
        public static double Iva(double n, double iva)
        {
            if (iva == 0)
            {
                return n * 0.15;
            }
            else
            {
                return n * iva;
            }
        }
    }
}