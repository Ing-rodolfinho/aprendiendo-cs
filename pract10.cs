//Gestion de productos
using System;
using System.Reflection;
namespace Tienda
{
    public class Producto
    {
        public static void Pra10()
        {
            bool salida = false;
            string[] prod = new string[10];
            try
            {
                while (!salida)
                {
                    Console.WriteLine("=========MENU========= \n1. actualizar stock \n2. ver stock \n3. buscar producto \n4. registrar producto \n5. eliminar producto \n6. salir \n digite una opcion: ");
                    int op = ValidarOp();
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("======= ACTUALIZAR STOCK ======= ");
                            for (int i = 0; i < prod.Length; i++)
                            {
                                Console.Write("Ingrese stock del producto " + (i + 1) + ": ");
                                prod[i] = validastring();
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
                            string buscar = validastring();
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
                            string regis = validastring();
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
                            string elim = validastring();
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
            }
            catch (Exception)
            {
                Console.WriteLine("algo ocurrio.");
            }
        }
        public static int ValidarOp()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int op))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else if (op < 1 || op > 6)
                {
                    Console.WriteLine("EL NUMERO DEBE ESTAR ENTRE 1 y 6");
                }
                else
                {
                    return op;
                }
            }
        }
        public static string validastring()
        {
            while (true)
            {
                string? d = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(d))
                {
                    Console.WriteLine("DIGITE UN DATO VALIDO");
                }
                else
                {
                    return d;
                }
            }
        }
    }
}