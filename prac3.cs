using System;

namespace practica
{
    public class Clase3
    {
        public static void Clas3()
        {
            bool correcto = false;
            int ed;

            while (!correcto)
            {
                try
                {
                    Console.WriteLine("Digite su edad:");
                    ed = Convert.ToInt32(Console.ReadLine());

                    if (ed >= 1 && ed <= 120)
                    {
                        correcto = true;
                        Console.WriteLine("Edad válida.");
                    }
                    else
                    {
                        Console.WriteLine("Edad fuera del rango (1-120).");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite un número válido.");
                }
            }
        }
    }
}