using System;

namespace practica
{
    public class Clase3
    {
        public static void Clas3()
        {
            int ed;
            try
            {
                Console.WriteLine("Digite su edad:");
                ed = ValidarEdad();
            }
            catch (Exception)
            {
                System.Console.WriteLine("ALGO OCURRIO");
            }
            finally
            {
                System.Console.WriteLine("FIN DEL PROGRAMA");
            }
        }
        public static int ValidarEdad()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int edad))
                {
                    System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else if (edad < 1 || edad > 120)
                {
                    System.Console.WriteLine("EL NUMERO DEBE SER MAYOR A 1 Y MENOR A 120");
                }
                else
                {
                    return edad;
                }
            }
        }
    }
}