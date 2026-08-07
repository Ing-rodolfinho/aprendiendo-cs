using System;
namespace clase2
{
    public class Practica1
    {
        public static void Factori()
        {
            int n = 0;
            do
            {
                System.Console.WriteLine("digite un numero entero");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            System.Console.WriteLine("el factorial de " + n + " es: " + factorial(n));

        }
        public static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
    }
}