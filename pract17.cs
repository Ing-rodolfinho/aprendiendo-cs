using System;
namespace practica17
{
    public class Pract17
    {
        public static void Main(string[] args)
        {
            double[] calificaciones = new double[10];
            Rellenar(calificaciones);
            System.Console.WriteLine("EL PROMEDIO DEL GRUPO ES: " + Promedio(calificaciones));
            System.Console.WriteLine("LA NOTA MAS BAJA FUE: " + calificaciones.Min());
            System.Console.WriteLine("LA NOTA MAS ALTA FUE: " + calificaciones.Max());
            System.Console.WriteLine("LA CANTIDAD DE APROBADOS ES: " + Apro(calificaciones));
            System.Console.WriteLine("LA CANTIDAD DE REPROBADOS ES: " + (10 - Apro(calificaciones)));
            Mostrar(calificaciones);
        }
        public static double Validar()
        {
            bool val;
            double num;
            double[] calificaciones = new double[10];
            while (true)
            {
                val = double.TryParse(Console.ReadLine(), out num);
                if (!val)
                {
                    System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else if (num < 0 || num > 100)
                {
                    System.Console.WriteLine("DIGITE UN VALOR ENTRE 0 y 100");
                }
                else
                {
                    return num;
                }
            }
        }
        public static double[] Rellenar(double[] calificaciones)
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                System.Console.WriteLine("DIGITE LA CALIFICACION " + (i + 1));
                calificaciones[i] = Validar();
            }
            return calificaciones;
        }
        public static double Promedio(double[] calificaciones)
        {
            double suma = 0;
            foreach (double ca in calificaciones)
            {
                suma += ca;
            }
            return suma / calificaciones.Length;
        }
        public static int Apro(double[] calificaciones)
        {
            int cont = 0;
            foreach (var ca in calificaciones)
            {
                if (ca >= 60)
                {
                    cont++;
                }
            }
            return cont;
        }
        public static void Mostrar(double[] calificaciones)
        {
            int cont = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] > Promedio(calificaciones))
                {
                    cont++;
                }
            }
            System.Console.WriteLine("EL TOTAL DE NOTAS SUPERIORES AL PROMEDIO ES: " + cont);
        }
    }
}