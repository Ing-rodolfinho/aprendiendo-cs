using System;

namespace clase2
{
    public class Practica2
    {
        public static void Iva1()
        {
            double iv = 0;
            double n = 0;
            bool val;

            try
            {
                do
                {
                    Console.Write("Ingrese el costo total de los productos: ");
                    val = double.TryParse(Console.ReadLine(), out n);

                    if (!val || n <= 0)
                    {
                        Console.WriteLine("Por favor, digite un costo válido mayor a 0.");
                    }

                } while (!val || n <= 0);


                do
                {
                    Console.Write("Ingrese el IVA: ");
                    val = double.TryParse(Console.ReadLine(), out iv);

                    if (!val || iv < 0)
                    {
                        Console.WriteLine("Por favor, digite un IVA válido mayor o igual a 0.");
                    }

                } while (!val || iv < 0);


                Console.WriteLine("El costo total con IVA es: " + Iva(n, iv));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Proceso terminado.");
            }
        }

        public static double Iva(double n, double iva)
        {
            return n + (n * iva / 100);
        }
    }
}