//Gestion de productos
using System;
using System.Reflection;
namespace Tienda
{
    public class Producto
    {
        public static void Pra10()
        {
            bool correcto;
            int op;
            string[] prod = new string[10];
            try
            {
                while (true)
                {
                    Console.WriteLine("=========MENU========= ");
                    Console.WriteLine("1. Actualizar Stock");
                    Console.WriteLine("2. Mostrar Stock");
                    Console.WriteLine("3. Buscar Producto");
                    Console.WriteLine("4. Registrar Producto");
                    Console.WriteLine("5. Eliminar Producto");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine("Ingrese una opcion: ");
                    correcto = int.TryParse(Console.ReadLine(), out op);
                    if (correcto && op > 0 && op <= 6)
                    {
                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("======= ACTUALIZAR STOCK ======= ");
                                for (int i = 0; i < prod.Length; i++)
                                {
                                    Console.Write("Ingrese stock del producto " + (i + 1) + ": ");
                                    prod[i] = Console.ReadLine() ?? "";
                                    if (i == 9)
                                    {
                                        System.Console.WriteLine("stock actualizado ");
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("======= VER STOCK ======= ");
                                for (int j = 0; j < prod.Length; j++)
                                {
                                    Console.WriteLine("Stock del producto " + (j + 1) + ": " + prod[j]);
                                }
                                break;
                            case 3:
                                Console.WriteLine("======= BUSCAR PRODUCTO ======= ");
                                System.Console.WriteLine("Digite el nombre del producto a buscar: ");
                                string? buscar = Console.ReadLine();
                                bool encontrado = false;
                                for (int k = 0; k < prod.Length; k++)
                                {
                                    if (buscar == prod[k])
                                    {
                                        System.Console.WriteLine("se encontro el producto: " + prod[k]);
                                        encontrado = true;
                                        break;
                                    }
                                }
                                if (!encontrado)
                                {
                                    System.Console.WriteLine("no se encontro producto.");
                                }
                                break;
                            case 4:
                                Console.WriteLine("======= REGISTRAR PRODUCTO ======= ");
                                Console.Write("Digite el nombre del producto a registrar: ");
                                string? regis = Console.ReadLine();
                                for (int l = 0; l < prod.Length; l++)
                                {
                                    if (regis == prod[l])
                                    {
                                        Console.WriteLine("el producto ya existe");
                                        break;
                                    }
                                    else if (regis != prod[l])
                                    {
                                        prod[prod.Length + 1] = regis ?? "";
                                        Console.WriteLine("el producto se registro exitosamente.");
                                        break;
                                    }
                                }
                                break;
                            case 5:
                                Console.WriteLine("======= ELIMINAR PRODUCTO ======= ");
                                Console.Write("Digite el nombre del producto a eliminar: ");
                                string? elim = Console.ReadLine();
                                bool eliminado = false;
                                for (int m = 0; m < prod.Length; m++)
                                {
                                    if (elim == prod[m])
                                    {
                                        System.Console.WriteLine("el producto " + elim + " se elimino.");
                                        prod[m] = "";
                                        eliminado = true;
                                        break;
                                    }
                                }
                                if (!eliminado)
                                {
                                    System.Console.WriteLine("no se encontro el producto.");
                                }
                                break;
                            case 6:
                                Console.WriteLine("Gracias por su preferencia.");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida.");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("algo ocurrio.");
            }
        }
    }
}