using System;
namespace Practica16
{
    public class Pract16
    {
        public static void Main(string[] args)
        {
            try
            {
                double TotalPrecios = 0;
                int CantidadProductos = 0;
                bool salida = false;
                bool val;
                int op = 0;
                List<string> NameProducto = new List<string>();
                List<double> PriceProducto = new List<double>();
                while (!salida)
                {
                    System.Console.WriteLine("=======SELECIONE UNA OPCION=========\n1. Agregar producto\n2. Mostrar productos\n3. Buscar producto\n4. Eliminar producto\n5. Mostrar cantidad de productos\n6. Mostrar cantidad de precios\n7. Salir");
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);
                        if (!val)
                        {
                            System.Console.WriteLine("Digite una opcion valida");
                        }
                        else if (op < 1 || op > 7)
                        {
                            System.Console.WriteLine("Digite una opcion entre 1 y 7");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            System.Console.WriteLine("========DIGITE EL NOMBRE DEL PRODUCTO=========");
                            NameProducto.Add(ValidarText());
                            System.Console.WriteLine("=========DIGITE EL PRECIO DEL PRODUCTO========");
                            PriceProducto.Add(ValidarNum());
                            System.Console.WriteLine("========= PRODUCTO AGREGADO =========");
                            CantidadProductos++;
                            TotalPrecios += PriceProducto[PriceProducto.Count - 1];
                            break;
                        case 2:
                            MostrarP(NameProducto, PriceProducto);
                            break;
                        case 3:
                            System.Console.WriteLine("=======DIGITE EL NOMBRE DEL PRODUCTO QUE DESEA BUSCAR=========");
                            Buscar(NameProducto, PriceProducto);
                            break;
                        case 4:
                            System.Console.WriteLine("=====DIGITE EL NOMBRE DEL PRODUCTO QUE DESEA ELIMINAR=======");
                            string Peliminado = ValidarText();
                            if (NameProducto.Contains(Peliminado))
                            {
                                int index = NameProducto.IndexOf(Peliminado);
                                double PrecioEliminado = PriceProducto[index];
                                NameProducto.RemoveAt(index);
                                PriceProducto.RemoveAt(index);
                                CantidadProductos--;
                                TotalPrecios -= PrecioEliminado;
                                System.Console.WriteLine("========PRODUCTO ELIMINADO=======");
                            }
                            else
                            {
                                System.Console.WriteLine("========PRODUCTO NO ENCONTRADO=======");
                            }
                            break;
                        case 5:
                            MostarCP(CantidadProductos);
                            break;
                        case 6:
                            MostrarTP(TotalPrecios);
                            break;
                        case 7:
                            salida = true;
                            break;

                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("algo fallo");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
        public static double ValidarNum()
        {
            double num;
            bool validar;
            while (true)
            {
                validar = double.TryParse(Console.ReadLine(), out num);
                if (!validar)
                {
                    System.Console.WriteLine("digite un valor valido");
                }
                else if (num < 0)
                {
                    System.Console.WriteLine("digite un valor mayor o igual a 0");
                }
                else
                {
                    return num;
                }
            }
        }
        public static string ValidarText()
        {
            while (true)
            {
                string text = Console.ReadLine()!;
                if (string.IsNullOrWhiteSpace(text))
                {
                    System.Console.WriteLine("digite un valor valido");
                }
                else
                {
                    return text;
                }
            }
        }
        public static void MostrarP(List<string> productos, List<double> precios)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                System.Console.WriteLine($"NOMBRE DEL PRODUCTO: {productos[i]} precio: {precios[i]}");
            }
        }
        public static void MostarCP(int CP)
        {
            System.Console.WriteLine($"CANTIDAD DE PRODUCTOS: {CP}");
        }
        public static void MostrarTP(double TP)
        {
            System.Console.WriteLine($"TOTAL DE PRECIOS: {TP}");
        }
        public static void Buscar(List<string> NameProducto, List<double> PriceProducto)
        {
            var name = ValidarText();
            if (NameProducto.Contains(name))
            {
                int index = NameProducto.IndexOf(name);
                System.Console.WriteLine("=======PRODUCTO ENCONTRADO=======");
                System.Console.WriteLine("NOMBRE DEL PRODUCTO: " + name);
                System.Console.WriteLine("PRECIO DEL PRODUCTO: " + PriceProducto[index]);
            }
            else
            {
                System.Console.WriteLine("=======PRODUCTO NO ENCONTRADO=======");
            }
        }
    }
}