using System;

namespace prac9
{
    public class Practica9
    {
        public static void Pra9()
        {
            bool val;
            double precio;
            double des;

            try
            {
                do
                {
                    Console.Write("Precio del producto: ");
                    val = double.TryParse(Console.ReadLine(), out precio);

                    if (!val)
                    {
                        Console.WriteLine("Dato inválido.");
                    }
                    else if (precio <= 0)
                    {
                        Console.WriteLine("El precio debe ser mayor a 0.");
                        val = false;
                    }

                } while (!val);


                do
                {
                    Console.Write("Digite el descuento: ");
                    val = double.TryParse(Console.ReadLine(), out des);

                    if (!val)
                    {
                        Console.WriteLine("Dato inválido.");
                    }
                    else if (des < 0 || des > 100)
                    {
                        Console.WriteLine("El descuento debe estar entre 0 y 100.");
                        val = false;
                    }

                } while (!val);


                Console.WriteLine("Precio Inicial: " + precio);
                Console.WriteLine("Descuento: " + des + "%");
                Console.WriteLine("Precio Final: " + CalDescuento(precio, des));
            }
            catch (Exception)
            {
                Console.WriteLine("Algo ocurrió.");
            }
            finally
            {
                Console.WriteLine("Proceso terminado.");
            }
        }

        public static double CalDescuento(double prec, double desc)
        {
            return prec - (prec * desc / 100);
        }
    }
}