using System;
namespace Clase3
{
    class Program
    {
        static void Clase3()
        {
            int op = 0;
            System.Console.WriteLine("digite una opcion");
            System.Console.WriteLine("1. suma");
            System.Console.WriteLine("2. resta");
            System.Console.WriteLine("3. multiplicacion");
            System.Console.WriteLine("4. division");
            System.Console.WriteLine("5. salir");
            do
            {
                if (int.TryParse(Console.ReadLine(), out op))
                {
                    switch (op)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                }
                else if (op < 1 || op > 5)
                {
                    System.Console.WriteLine("opcion invalida");
                }
                else
                {
                    System.Console.WriteLine("debes ingresar un numero");
                }
            } while (op != 5);
        }
    }
}