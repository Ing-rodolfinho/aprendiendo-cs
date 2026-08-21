using System;
namespace Practica11
{
    public class Pract11
    {
        public static void P11()
        {
            try
            {
                double SumaPasivo = 0, SumaActivo = 0;
                bool salida = false;
                int op;
                while (!salida)
                {
                    System.Console.WriteLine("=========Digite un aopcion========= \n 1.Registrar Pasivo \n 2.Registrar Activo \n 3.Mostrar Patrimonio \n 4.Mostrar informacion \n 5.Salir");
                    op = ValidarOpcion();   
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine("Digite el valor total del pasivo");
                            double pasivo;
                            pasivo = Validardou();
                            SumaPasivo += pasivo;
                            System.Console.WriteLine("pasivo registrado exitosamente");
                            break;
                        case 2:
                            System.Console.WriteLine("Digite el valor del activo");
                            double activo;
                            activo = Validardou();
                            SumaActivo += activo;
                            System.Console.WriteLine("activo registrado exitosamente");
                            break;
                        case 3:
                            MostrarPatrimonio(SumaPasivo, SumaActivo);
                            break;
                        case 4:
                            Mostrar(SumaPasivo, SumaActivo);
                            break;
                        case 5:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo paso");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
        public static void Mostrar(double pasivo, double activo)
        {
            System.Console.WriteLine("===========Informacion===========");
            System.Console.WriteLine("La suma de los pasivos es: " + pasivo);
            System.Console.WriteLine("La suma de los activos es: " + activo);
            System.Console.WriteLine("---------------------------------");
        }
        public static void MostrarPatrimonio(double pasivo, double activo)
        {
            double patrimonio = activo - pasivo;
            System.Console.WriteLine("===========Informacion===========");
            System.Console.WriteLine("El patrimonio es: " + patrimonio);
            System.Console.WriteLine("---------------------------------");
        }
        public static int Validarint(string men)
        {
            int num;
            while (true)
            {
                System.Console.WriteLine(men);
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN NUMERO VALIDO");
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
        public static double Validardou()
        {
            double num;
            while(true)
            {
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN NUMERO VALIDO");
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
        public static int ValidarOpcion()
        {
            int num;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("DIGITE UN NUMERO VALIDO");
                }
                else if (num < 1 || num > 5)
                {
                    System.Console.WriteLine("EL NUMERO DEBE SER MAYOR A 0 y menor a 5");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}