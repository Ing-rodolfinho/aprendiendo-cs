using System;
using System.Net;
namespace prac2
{
    public class clase2
    {
        public static void Clas2()
        {
            int num;
            int den;
            double div;
            try
            {
                System.Console.WriteLine("digite el numerador");
                num = Validar();
                System.Console.WriteLine("digite el denominador");
                den = ValidarDenominador();
                div = (double)num / den;
                System.Console.WriteLine(div);
            }
            catch (Exception)
            {
                Console.WriteLine("ALGO OCURRIO");
            }
            finally
            {
                Console.WriteLine("FIN DEL PROGRAMA");
            }
        }
        public static int Validar()
        {
            int num;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else
                {
                    return num;
                }
            }
        }
        public static int ValidarDenominador()
        {
            int num;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (num == 0)
                {
                    System.Console.WriteLine("EL DENOMINADOR NO PUEDE SER 0");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}