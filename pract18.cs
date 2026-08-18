using System;
namespace Practica18
{
    public class Pract18
    {
        public static void P18()
        {
            try
            {
                List<string> libros = new();
                bool salida = false;
                while (!salida)
                {
                    System.Console.WriteLine("SELECCIONE UNA DES LAS SIGUIENTES OPCIONES");
                    System.Console.WriteLine("1. AGREGAR LIBRO \n2. BUSCAR \n3. PRESTAR \n4. DEVOLVER LIBRO \n5. MOSTRAR LIBROS DISPONIBLES \n6. SALIR");
                    int op = validar();
                    switch (op)
                    {
                        case 1:
                            Agregar(libros);
                            break;
                        case 2:
                            Buscar(libros);
                            break;
                        case 3:
                            Prestar(libros);
                            break;
                        case 4:
                            Devolver(libros);
                            break;
                        case 5:
                            Mostrar(libros);
                            break;
                        case 6:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("ERROR");
            }
            finally
            {
                System.Console.WriteLine("FIN DEL PROGRAMA");
            }
        }
        public static int validar()
        {
            int op;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else if (op < 1 || op > 6)
                {
                    System.Console.WriteLine("DIGITE UN VALOR ENTRE 1 y 6");
                }
                else
                {
                    return op;
                }
            }
        }
        public static void Agregar(List<string> libros)
        {
            System.Console.WriteLine("DIGITE EL TITULO DEL LIBRO");
            while (true)
            {
                string titulo = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(titulo))
                {
                    System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else
                {
                    libros.Add(titulo);
                    System.Console.WriteLine("LIBRO AGREGADO");
                    break;
                }
            }
        }
        public static void Buscar(List<string> libros)
        {
            if (libros.Count > 0)
            {
                System.Console.WriteLine("DIGITE EL TITULO DEL LIBRO");
                string titulo = Console.ReadLine()!;
                if (libros.Contains(titulo))
                {
                    System.Console.WriteLine("LIBRO ENCONTRADO");
                }
                else
                {
                    System.Console.WriteLine("LIBRO NO ENCONTRADO");
                }
            }
            else
            {
                System.Console.WriteLine("NO HAY LIBROS DISPONIBLES");
            }
        }
        public static void Prestar(List<string> libros)
        {
            if (libros.Count > 0)
            {
                System.Console.WriteLine("DIGITE EL TITULO DEL LIBRO");
                string titulo = Console.ReadLine()!;
                if (libros.Contains(titulo))
                {
                    libros.Remove(titulo);
                    System.Console.WriteLine("LIBRO PRESTADO");
                }
                else
                {
                    System.Console.WriteLine("LIBRO NO ENCONTRADO");
                }
            }
            else
            {
                System.Console.WriteLine("NO HAY LIBROS PARA PRESTAR");
            }
        }
        public static void Devolver(List<string> libros)
        {
            System.Console.WriteLine("DIGITE EL TITULO DEL LIBRO");
            string titulo = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                System.Console.WriteLine("DIGITE UN VALOR VALIDO");
            }
            else
            {
                libros.Add(titulo);
                System.Console.WriteLine("LIBRO DEVUELTO");
            }
        }
        public static void Mostrar(List<string> libros)
        {
            if (libros.Count > 0)
            {
                libros.Sort();
                foreach (var libro in libros)
                {
                    System.Console.WriteLine(libro);
                }
            }
            else
            {
                System.Console.WriteLine("NO HAY LIBROS DISPONIBLES");
            }
        }
    }
}