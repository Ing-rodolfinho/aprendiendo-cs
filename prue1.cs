using System;

namespace Aprendiendo
{
    public class Prueba1
    {
        public static void P1()
        {
            try
            {
                string nombre;

                while (true)
                {
                    Console.Write("Digite su nombre: ");
                    nombre = Console.ReadLine()!;

                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Ingrese un nombre válido");
                    }
                    else
                    {
                        break;
                    }
                }

                int edad;

                while (true)
                {
                    Console.Write("Digite su edad: ");

                    bool val = int.TryParse(Console.ReadLine(), out edad);

                    if (!val)
                    {
                        Console.WriteLine("Ingrese un número entero válido");
                    }
                    else if (edad < 0 || edad > 150)
                    {
                        Console.WriteLine("Ingrese una edad válida");
                    }
                    else
                    {
                        break;
                    }
                }

                double promedio;

                while (true)
                {
                    Console.Write("Digite su promedio: ");

                    bool val = double.TryParse(Console.ReadLine(), out promedio);

                    if (!val)
                    {
                        Console.WriteLine("Ingrese un número válido");
                    }
                    else if (promedio < 0 || promedio > 10)
                    {
                        Console.WriteLine("Ingrese un promedio válido");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("\nDatos ingresados:");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Promedio: " + promedio);
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }
    }
}