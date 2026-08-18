using System;
using System.ComponentModel;
namespace Practica19
{
    public class Pract19
    {
        public static void Main(string[] args)
        {
            try
            {
                bool salida = false;
                List<string> nombres = new List<string>();
                List<int> notas = new List<int>();
                while (!salida)
                {
                    int op;
                    System.Console.WriteLine("ELIGA UNA OPCION \n 1. AGREGAR ESTUDIANTE \n 2. BUSVCAR \n 3. ELIMINAR ESTUDIANTE \n 4. MOSTRAR ESTUDIANTE \n 5. MOSTRAR PROMEDIO \n 6. MOSTRAR ESTUDIANTE CON MAYOR NOTA \n 7. SALIR");
                    while (true)
                    {


                        if (!int.TryParse(Console.ReadLine(), out op))
                        {
                            System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                        }
                        else if (op < 1 || op > 7)
                        {
                            System.Console.WriteLine("DIGITE UN VALOR ENTRE 1 y 7");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            {
                                Agregar(nombres, notas);
                            }
                            break;

                        case 2:
                            {
                                Buscar(nombres, notas);
                            }
                            break;

                        case 3:
                            {

                                Eliminar(nombres, notas);
                            }
                            break;

                        case 4:
                            {
                                Mostrar(nombres, notas);
                            }
                            break;

                        case 5:
                            {
                                Promedio(notas);
                            }
                            break;

                        case 6:
                            {
                                MejorNota(notas, nombres);
                            }
                            break;

                        case 7:
                            {
                                salida = true;
                            }
                            break;

                        default:
                            {
                                System.Console.WriteLine("OPCION INVALIDA");
                            }
                            break;
                    }

                }
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
        public static string Validartext()
        {
            while (true)
            {
                string name = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(name))
                {
                    System.Console.WriteLine("DIGITE UN NOMBRE VALIDO");
                }
                else
                {
                    return name;
                }
            }
        }
        public static int ValidarNota()
        {
            int nota;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out nota))
                {
                    System.Console.WriteLine("DIGITE UN VALOR VALIDO");
                }
                else if (nota < 0 || nota > 100)
                {
                    System.Console.WriteLine("DIGITE UN VALOR ENTRE 0 Y 100");
                }
                else
                {
                    return nota;
                }
            }
        }
        public static void Eliminar(List<string> nombres, List<int> notas)
        {
            System.Console.WriteLine("DIGITE EL NOMBRE DEL ESTUDIANTE A ELIMINAR");
            string name = Console.ReadLine()!;
            if (nombres.Contains(name))
            {
                int i = nombres.IndexOf(name);
                nombres.RemoveAt(i);
                notas.RemoveAt(i);
                System.Console.WriteLine("ESTUDIANTE ELIMINADO");
            }
            else
            {
                System.Console.WriteLine("ESTUDIANTE NO ENCONTRADO");
            }
        }
        public static void Buscar(List<string> nombres, List<int> notas)
        {
            System.Console.WriteLine("DIGITE EL NOMBRE DEL ESTUDIANTE");
            string buscado = Validartext();
            if (nombres.Contains(buscado))
            {
                int i = nombres.IndexOf(buscado);
                System.Console.WriteLine("EL ALUMNO " + buscado + " TUVO UNA CALIFICACION DE " + notas[i]);
            }
            else
            {
                System.Console.WriteLine("ESTUDIANTE NO ENCONTRADO");
            }
        }
        public static void Agregar(List<string> nombres, List<int> notas)
        {
            System.Console.WriteLine("DIGITE EL NOMBRE DEL ESTUDIANTE");
            string name = Validartext();
            nombres.Add(name);
            System.Console.WriteLine("DIGITE LA NOTA DEL ESTUDIANTE");
            int nota = ValidarNota();
            notas.Add(nota);
            System.Console.WriteLine("ESTUDIANTE AGREGADO");
        }
        public static void Mostrar(List<string> nombres, List<int> notas)
        {
            if (nombres.Count == 0)
            {
                System.Console.WriteLine("NO HAY ESTUDIANTES");
                return;
            }
            for (int i = 0; i < nombres.Count; i++)
            {
                System.Console.WriteLine("EL ALUMNO " + nombres[i] + " TUVO UNA CALIFICACION DE " + notas[i]);
            }
        }
        public static void Promedio(List<int> notas)
        {
            int suma = 0;
            if (notas.Count == 0)
            {
                System.Console.WriteLine("NO HAY ESTUDIANTES");
                return;
            }
            foreach (int nota in notas)
            {
                suma += nota;
            }
            double promedio = (double)suma / notas.Count;
            System.Console.WriteLine("EL PROMEDIO ES " + promedio);
        }
        public static void MejorNota(List<int> notas, List<string> nombres)
        {
            if (notas.Count == 0)
            {
                System.Console.WriteLine("NO HAY ESTUDIANTES");
                return;
            }
            int mejorNota = notas[0];
            string mejorAlumno = nombres[0];
            for (int i = 1; i < notas.Count; i++)
            {
                if (notas[i] > mejorNota)
                {
                    mejorNota = notas[i];
                    mejorAlumno = nombres[i];
                }
            }
            System.Console.WriteLine("EL ALUMNO " + mejorAlumno + " TUVO LA MEJOR CALIFICACION DE " + mejorNota);
        }
    }
}