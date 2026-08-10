using System;
namespace Juegos
{
    class Juego
    {
        public static void J1()
        {
            try
            {
                bool val;
                int op = 0;
                while (op != 2)
                {
                    System.Console.WriteLine("========DIGITE UNA OPCION========");
                    System.Console.WriteLine("1.Jugar");
                    System.Console.WriteLine("2.Salir");
                    while (true)
                    {
                        val = int.TryParse(Console.ReadLine(), out op);
                        if (!val)
                        {
                            System.Console.WriteLine("dato invalido");
                        }
                        else if (op < 1 || op > 2)
                        {
                            System.Console.WriteLine("el valor debe estar entre 1 y 2");
                        }
                        else
                        {
                            break;
                        }
                    }
                    switch (op)
                    {
                        case 1:
                            int perder = 0;
                            int ganar = 0;
                            int empate = 0;
                            System.Console.WriteLine("digite la cantidad de rondas");
                            int rounds = 0;
                            while (true)
                            {
                                while (val == true)
                                {
                                    val = int.TryParse(Console.ReadLine(), out rounds);
                                    if (!val)
                                    {
                                        System.Console.WriteLine("dato invalido");
                                    }
                                    else if (rounds < 1)
                                    {
                                        System.Console.WriteLine("el valor debe ser mayor a 0");
                                    }
                                    else
                                    {
                                        val = false;
                                    }
                                }
                                int ele;
                                for (int i = 0; i < rounds; i++)
                                {
                                    while (true)
                                    {
                                        Menu();
                                        val = int.TryParse(Console.ReadLine(), out ele);
                                        if (!val)
                                        {
                                            System.Console.WriteLine("dato invalido");
                                        }
                                        else if (ele < 1 || ele > 3)
                                        {
                                            System.Console.WriteLine("el valor debe estar entre 1 y 3");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    System.Console.WriteLine("===============RONDA " + (i + 1) + "=============== ");
                                    Random aleatorio = new Random();
                                    int num = aleatorio.Next(1, 3);
                                    System.Console.WriteLine("Escojistes: " + Eleccion(ele));
                                    System.Console.WriteLine("----------vs-------------");
                                    System.Console.WriteLine("La maquina escogio: " + Eleccion(num));
                                    if (ele == num)
                                    {
                                        System.Console.WriteLine("---------------");
                                        System.Console.WriteLine("Empate");
                                        System.Console.WriteLine("---------------");
                                        empate++;
                                    }
                                    else if (ele == 1 && num == 3 || ele == 2 && num == 1 || ele == 3 && num == 2)
                                    {
                                        System.Console.WriteLine("---------------");
                                        System.Console.WriteLine("Ganaste");
                                        System.Console.WriteLine("---------------");
                                        ganar++;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("---------------");
                                        System.Console.WriteLine("Perdiste");
                                        System.Console.WriteLine("---------------");
                                        perder++;
                                    }
                                }
                                System.Console.WriteLine("Rondas jugadas: " + rounds);
                                System.Console.WriteLine("Ganadas: " + ganar);
                                System.Console.WriteLine("Perdidas: " + perder);
                                System.Console.WriteLine("Empates: " + empate);
                                break;
                            }
                            break;
                        case 2:
                            System.Console.WriteLine("programa finalizado");
                            break;
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Algo oucrrio");
            }
        }
        public static void Menu()
        {
            System.Console.WriteLine("========MENU========");
            System.Console.WriteLine("1.Piedra");
            System.Console.WriteLine("2.Papel");
            System.Console.WriteLine("3.Tijera");
        }
        public static string Eleccion(int let)
        {
            switch (let)
            {
                case 1:
                    return "Piedra";
                case 2:
                    return "Papel";
                case 3:
                    return "Tijera";
                default:
                    return "Opción inválida";
            }
        }
    }
}