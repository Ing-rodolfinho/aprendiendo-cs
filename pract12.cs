using System;
using System.Reflection.Metadata;
namespace Practica12
{
    public class Pract12
    {
        public static void P12()
        {
            try
            {
                bool val;
                bool salida = false;
                double Saldo = 0;
                double DepositoTotal = 0;
                double RetiroTotal = 0;
                int Movimiento = 0;
                while (!salida)
                {
                    int op = 0;
                    System.Console.WriteLine("=============CONTROL CONTABLE=============");
                    System.Console.WriteLine("1. Registra Deposito");
                    System.Console.WriteLine("2. registrar Retiro");
                    System.Console.WriteLine("3. Mostrar Saldo");
                    System.Console.WriteLine("4. Mostrar movimiento");
                    System.Console.WriteLine("5. Salir");
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);
                        if (!val)
                        {
                            System.Console.WriteLine("Tipo de dato invalido");
                        }
                        else if (op < 1 || op > 5)
                        {
                            System.Console.WriteLine("opcion invalida");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            double dep = 0;
                            System.Console.WriteLine("========DIGITE EL DEPOSITO========");
                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out dep);
                                if (!val)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (dep <= 0)
                                {
                                    System.Console.WriteLine("deposito invalido");
                                }
                                else
                                {
                                    DepositoTotal += dep;
                                    Saldo += dep;
                                    Movimiento += 1;
                                    System.Console.WriteLine("deposito registrado exitosamente");
                                    break;
                                }
                            }
                            break;
                        case 2:
                            double ret = 0;
                            System.Console.WriteLine("========DIGITE EL RETIRO========");
                            while (true)
                            {
                                val = double.TryParse(Console.ReadLine(), out ret);
                                if (!val)
                                {
                                    System.Console.WriteLine("tipo de dato invalido");
                                }
                                else if (ret <= 0)
                                {
                                    System.Console.WriteLine("retiro invalido");
                                }
                                else if (ret > Saldo)
                                {
                                    System.Console.WriteLine("saldo insuficiente");
                                    continue;
                                }
                                else
                                {
                                    RetiroTotal += ret;
                                    Saldo -= ret;
                                    Movimiento += 1;
                                    System.Console.WriteLine("retiro registrado exitosamente");
                                    break;
                                }
                            }
                            break;
                        case 3:
                            MostrarSaldo(Saldo);
                            break;
                        case 4:
                            MostrarMovimiento(DepositoTotal, RetiroTotal, Movimiento);
                            break;
                        case 5:
                            salida = true;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo salio mal");
            }
            finally
            {
                System.Console.WriteLine("Fin del programa");
            }
        }
        public static void MostrarSaldo(double Saldo)
        {
            System.Console.WriteLine("===========SALDO===========");
            System.Console.WriteLine("el saldo actual es: " + Saldo);
            System.Console.WriteLine("---------------------------");
        }
        public static void MostrarMovimiento(double DepositoTotal, double RetiroTotal, int Movimiento)
        {
            System.Console.WriteLine("===========MOVIMIENTO===========");
            System.Console.WriteLine("el deposito total es: " + DepositoTotal);
            System.Console.WriteLine("el retiro total es: " + RetiroTotal);
            System.Console.WriteLine("el numero de movimientos es: " + Movimiento);
            System.Console.WriteLine("---------------------------");
        }
    }
}