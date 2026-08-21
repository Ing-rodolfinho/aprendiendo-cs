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
                bool salida = false;
                double Saldo = 0;
                double DepositoTotal = 0;
                double RetiroTotal = 0;
                int Movimiento = 0;
                int op;
                while (!salida)
                {
                    System.Console.WriteLine("=============CONTROL CONTABLE============= \n 1.Registra Deposito \n 2.registrar Retiro \n 3.Mostrar Saldo \n 4.Mostrar movimiento \n 5.Salir");
                    op = ValidarOp();
                    switch (op)
                    {
                        case 1:
                            double dep = 0;
                            System.Console.WriteLine("========DIGITE EL DEPOSITO========");
                            dep = ValidarDou();
                            DepositoTotal += dep;
                            Saldo += dep;
                            Movimiento += 1;
                            System.Console.WriteLine("deposito registrado exitosamente");
                            break;
                        case 2:
                            double ret = 0;
                            System.Console.WriteLine("========DIGITE EL RETIRO========");
                            ret = ValidarDou();
                            if (ret > Saldo)
                            {
                                System.Console.WriteLine("saldo insuficiente");
                                continue;
                            }
                            RetiroTotal += ret;
                            Saldo -= ret;
                            Movimiento += 1;
                            System.Console.WriteLine("retiro registrado exitosamente");
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
        public static int ValidarOp()
        {
            int op;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    System.Console.WriteLine("tipo de dato invalido");
                }
                else if (op < 1 || op > 5)
                {
                    System.Console.WriteLine("opcion invalida");
                }
                else
                {
                    return op;
                }
            }
        }
        public static double ValidarDou()
        {
            double num;
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    System.Console.WriteLine("tipo de dato invalido");
                }
                else if (num <= 0)
                {
                    System.Console.WriteLine("el numero debe ser mayor a 0");
                }
                else
                {
                    return num;
                }
            }
        }
    }
}