using System;
using System.Collections.Generic;

namespace Tienda
{
    public class Producto
    {
        public static void Pra10()
        {
            bool correcto;
            int op;

            List<string> prod = new List<string>();

            try
            {
                while (true)
                {
                    Console.WriteLine("========= MENU =========");
                    Console.WriteLine("1. Actualizar Stock");
                    Console.WriteLine("2. Mostrar Stock");
                    Console.WriteLine("3. Buscar Producto");
                    Console.WriteLine("4. Registrar Producto");
                    Console.WriteLine("5. Eliminar Producto");
                    Console.WriteLine("6. Salir");
                    Console.Write("Ingrese una opcion: ");

                    correcto = int.TryParse(Console.ReadLine(), out op);

                    if (correcto && op > 0 && op <= 6)
                    {
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("======= ACTUALIZAR STOCK =======");

                                for (int i = 0; i < prod.Count; i++)
                                {
                                    Console.Write("Ingrese stock del producto " + (i + 1) + ": ");
                                    prod[i] = Console.ReadLine() ?? "";
                                }

                                Console.WriteLine("Stock actualizado.");
                                break;

                            case 2:
                                Console.WriteLine("======= VER STOCK =======");

                                for (int j = 0; j < prod.Count; j++)
                                {
                                    Console.WriteLine("Stock del producto " + (j + 1) + ": " + prod[j]);
                                }
                                break;

                            case 3:
                                Console.WriteLine("======= BUSCAR PRODUCTO =======");
                                Console.Write("Digite el nombre del producto a buscar: ");

                                string? buscar = Console.ReadLine();
                                bool encontrado = false;

                                for (int k = 0; k < prod.Count; k++)
                                {
                                    if (buscar == prod[k])
                                    {
                                        Console.WriteLine("Se encontró el producto: " + prod[k]);
                                        encontrado = true;
                                        break;
                                    }
                                }

                                if (!encontrado)
                                {
                                    Console.WriteLine("No se encontró el producto.");
                                }
                                break;

                            case 4:
                                Console.WriteLine("======= REGISTRAR PRODUCTO =======");
                                Console.Write("Digite el nombre del producto a registrar: ");

                                string? regis = Console.ReadLine();
                                bool existe = false;

                                foreach (string producto in prod)
                                {
                                    if (producto == regis)
                                    {
                                        existe = true;
                                        break;
                                    }
                                }

                                if (existe)
                                {
                                    Console.WriteLine("El producto ya existe.");
                                }
                                else
                                {
                                    prod.Add(regis ?? "");
                                    Console.WriteLine("El producto se registró exitosamente.");
                                }
                                break;

                            case 5:
                                Console.WriteLine("======= ELIMINAR PRODUCTO =======");
                                Console.Write("Digite el nombre del producto a eliminar: ");

                                string? elim = Console.ReadLine();

                                if (prod.Remove(elim ?? ""))
                                {
                                    Console.WriteLine("El producto " + elim + " se eliminó.");
                                }
                                else
                                {
                                    Console.WriteLine("No se encontró el producto.");
                                }
                                break;

                            case 6:
                                Console.WriteLine("Gracias por su preferencia.");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo ocurrió.");
            }
        }
    }
}