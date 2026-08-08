using System;
namespace clase2
{
    public class E2
    {
        public static void Factori()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Digite un número entero: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Debe ser mayor a 0.");
                    }
                    else
                    {
                        Console.WriteLine("El factorial de " + n + " es: " + factorial(n));
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Debe ingresar un número entero válido.");
                }
            }
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