using System;
namespace prac9
{
    public class Practica9
    {
        public static void Pra9()
        {
            bool val;
            try
            {
                do
                {
                    System.Console.WriteLine("Precio del producto");
                    val = double.TryParse(Console.ReadLine(), out double precio);
                    if (!val)
                    {
                        System.Console.WriteLine("dato imvalido");
                    }
                    else if (precio <= 0)
                    {
                        System.Console.WriteLine("el precio debe ser mayor a 0");
                        val = false;
                    }
                    else
                    {
                        while (true)
                        {
                            System.Console.WriteLine("digite el descuento");
                            val = double.TryParse(Console.ReadLine(), out double des);
                            if (!val)
                            {
                                System.Console.WriteLine("dato imvalido");
                            }
                            else if (des <= 0)
                            {
                                System.Console.WriteLine("el descuento debe ser mayor a 0");
                                val = false;
                            }
                            else
                            {
                                System.Console.WriteLine($"precio final es de:" + CalDescuento(precio, des));
                                break;
                            }

                        }
                    }

                } while (!val);

            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo ocurrio");
            }
        }
        public static double CalDescuento(double prec, double desc)
        {
            return prec - (prec * desc);
        }
    }
}