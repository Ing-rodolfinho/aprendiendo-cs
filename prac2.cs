using System;
namespace prac2
{
    public class clase2
    {
        public static void Clas2()
        {
            bool correcto = false;
            bool correcto2 = false;
            int num = 0;
            int den;
            double div;
            while (correcto == false)
            {
                try
                {
                    System.Console.WriteLine("digite el numerador");
                    num = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("digite un numero valido");
                }
            }
            while (correcto2 == false)
            {
                try
                {
                    System.Console.WriteLine("digite el denominador");
                    den = Convert.ToInt32(Console.ReadLine());
                    if (den == 0)
                    {
                        System.Console.WriteLine("denominador no puede ser 0");
                        correcto2 = false;
                    }
                    else
                    {
                        div = (double)num / den;
                        System.Console.WriteLine(div);
                        correcto2 = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("digite un numero valido");
                }
            }
        }
    }
}