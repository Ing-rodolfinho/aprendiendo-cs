using System;

namespace EXcep
{
    public class Excepciones
    {
        public static void EX()
        {
            int entero;
            bool correcto = false;

            while (correcto == false)
            {
                try
                {
                    Console.WriteLine("Digite un número entero:");
                    entero = Convert.ToInt32(Console.ReadLine());
                    correcto = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ha ingresado un valor no válido. Intente nuevamente.");
                }
            }
        }
    }
}