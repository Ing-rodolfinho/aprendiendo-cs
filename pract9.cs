using System;

namespace prac9
{
    public class Practica9
    {
        public static void Pra9()
        {
            double precio;
            double des;
            try
            {
                Console.Write("Precio del producto: ");
                precio = Validar();
                Console.Write("Digite el descuento: ");
                do
                {
                    des = Validar();
                } while (des <= 0 || des > 100);
                Console.WriteLine("Precio Inicial: " + precio);
                Console.WriteLine("Descuento: " + des + "%");
                Console.WriteLine("Precio Final: " + CalDescuento(precio, des));
            }
            catch (Exception)
            {
                Console.WriteLine("algo ocurrio.");
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
        public static double Validar()
        {
            double num;
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (num <= 0)
                {
                    System.Console.WriteLine("EL NUMERO DEBE SER MAYOR A 0");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}