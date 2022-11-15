// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

namespace Proyecto_Final //Andrea Cifuentes - 1221519 y José Molina - 1308819
{
    class Program
    {
        public static string[,] equipos = new string[8, 4];
        public static bool mostrarSimulacion = false;
        static void Main(string[] args)
        {

            menu();

        }

        public static void menu()
        {

            int eleccion;

            if (mostrarSimulacion == false)
            {
                Console.WriteLine("Bienvenido al Ingreso de Equipos\ndel Mundial Qatar 2022");
                Console.WriteLine("Porfavor, elija una de las opciones para comenzar");
                Console.WriteLine("1) Ingreso de Equipos");
                Console.WriteLine("2) Editar Equipos");
                Console.WriteLine("3) Mostrar Información de los Equipos Ingresados");
            }
            else
            {
                Console.WriteLine("Bienvenido al Ingreso de Equipos\ndel Mundial Qatar 2022");
                Console.WriteLine("Porfavor, elija una de las opciones para comenzar");
                Console.WriteLine("1) Ingreso de Equipos");
                Console.WriteLine("2) Editar Equipos");
                Console.WriteLine("3) Mostrar Información de los Equipos Ingresados");
                Console.WriteLine("4) Iniciar Simulación\n");
            }
            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.Clear();
                    agregarEquipos();
                    break;
                case 2:
                    Console.Clear();
                    editarEquipos();
                    break;
                case 3:
                    Console.Clear();
                    mostrarEquipos();
                    break;
                case 4:
                    Console.Clear();
                    simulacion();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("El numero ingresador no existe\nPorfavor ingreselo nuevamente\n");
                    menu();
                    break;
            }
        }

        public static void agregarEquipos()
        {
            for (int fila = 0; fila < 8; fila++)
            {
                string nombreEquipo;
                int PG, PP, PE;
                Console.WriteLine("Ingrese el nombre del Equipo:");
                nombreEquipo = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de Partidos Ganados:");
                PG = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Partidos Perdidos:");
                PP = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Partidos Empatados:");
                PE = int.Parse(Console.ReadLine());

                equipos[fila, 0] = nombreEquipo;
                equipos[fila, 1] = PG.ToString();
                equipos[fila, 2] = PP.ToString();
                equipos[fila, 3] = PE.ToString();

                if (!Regex.IsMatch(nombreEquipo, @"^[a-zA-Z]+$"))
                {
                    while (!Regex.IsMatch(nombreEquipo, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("El Nombre del Equipo no debe contener numeros\nIngreselo nuevamente.");
                        nombreEquipo = Console.ReadLine();
                        equipos[fila, 0] = nombreEquipo;
                    }
                }
                if (PG + PP + PE != 4)
                {
                    while (PG + PP + PE != 4)
                    {
                        Console.WriteLine("La sumatoria de todos los partidos anteriores debe ser 4\nIngreselos nuevamente\n");
                        Console.WriteLine("Ingrese la cantidad de Partidos Ganados:");
                        PG = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de Partidos Perdidos:");
                        PP = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de Partidos Empatados:");
                        PE = int.Parse(Console.ReadLine());
                        equipos[fila, 1] = PG.ToString();
                        equipos[fila, 2] = PP.ToString();
                        equipos[fila, 3] = PE.ToString();
                    }
                }
            }
            mostrarSimulacion = true;
            Console.Clear();
            menu();
        }

        public static void editarEquipos()
        {
            string nombreEquipo;
            int numeroEquipo, PG, PP, PE;
            Console.WriteLine("Ingrese el numero de equipo que quiera editar:");
            numeroEquipo = int.Parse(Console.ReadLine());
            if (numeroEquipo >= 1 && numeroEquipo <= 8)
            {
                numeroEquipo = numeroEquipo - 1;
                Console.WriteLine("Ingrese el nombre del Equipo:");
                nombreEquipo = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de Partidos Ganados:");
                PG = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Partidos Perdidos:");
                PP = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de Partidos Empatados:");
                PE = int.Parse(Console.ReadLine());

                equipos[numeroEquipo, 0] = nombreEquipo;
                equipos[numeroEquipo, 1] = PG.ToString();
                equipos[numeroEquipo, 2] = PP.ToString();
                equipos[numeroEquipo, 3] = PE.ToString();

                if (!Regex.IsMatch(nombreEquipo, @"^[a-zA-Z]+$"))
                {
                    while (!Regex.IsMatch(nombreEquipo, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("El Nombre del Equipo no debe contener numeros\nIngreselo nuevamente.");
                        nombreEquipo = Console.ReadLine();
                        equipos[numeroEquipo, 0] = nombreEquipo;
                    }
                }
                if (PG + PP + PE != 4)
                {
                    while (PG + PP + PE != 4)
                    {
                        Console.WriteLine("La sumatoria de todos los partidos anteriores debe ser 4\nIngreselos nuevamente\n");
                        Console.WriteLine("Ingrese la cantidad de Partidos Ganados:");
                        PG = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de Partidos Perdidos:");
                        PP = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de Partidos Empatados:");
                        PE = int.Parse(Console.ReadLine());
                        equipos[numeroEquipo, 1] = PG.ToString();
                        equipos[numeroEquipo, 2] = PP.ToString();
                        equipos[numeroEquipo, 3] = PE.ToString();
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El numero de equipo que ingresaste es incorrecto, vuelvelo a ingresar\n");
                editarEquipos();
            }
            Console.Clear();
            Console.WriteLine("Has editado exitosamente el equipo\n");
            menu();
        }

        public static void mostrarEquipos()
        {
            for (int fila = 0; fila < 8; fila++)
            {
                Console.WriteLine(equipos[fila, 0] + " " + equipos[fila, 1] + " " + equipos[fila, 2] + " " + equipos[fila, 3] + "\n");
            }
            Console.ReadKey();
            Console.Clear();
            menu();
        }

        public static void simulacion()
        {
            double[,] cuartosFinal = new double[8, 3];
            string[,] semifinal = new string[4, 6];
            string[,] final = new string[2, 6];
            double poderEquipo, resultado, golesFavor = 0;
            Console.WriteLine("Asi quedan las llaves de los cuartos de final:");
            Random rand = new Random();
            List<int> listNumbers = new List<int>();
            int number;
            for (int i = 0; i < 8; i++)
            {
                do
                {
                    number = rand.Next(1, 9);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(equipos[listNumbers[i] - 1, 0]);
            }
            Console.ReadKey();
            Console.WriteLine("Resultados de los partidos:\n");
            for (int i = 0; i < 8; i++)
            {
                poderEquipo = (Double.Parse(equipos[listNumbers[i] - 1, 1]) * 0.7 - Double.Parse(equipos[listNumbers[i] - 1, 2]) * 0.2 + Double.Parse(equipos[listNumbers[i] - 1, 3]) * 0.1) / 4;
                cuartosFinal[i, 0] = poderEquipo;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int oportunidadGol = 0; oportunidadGol < 6; oportunidadGol++)
                {
                    resultado = rand.NextDouble();
                    if (resultado < cuartosFinal[i, 0])
                    {
                        golesFavor++;
                    }
                    cuartosFinal[i, 1] = golesFavor;
                }
                golesFavor = 0;
            }

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(equipos[listNumbers[i] - 1, 0] + " - " + cuartosFinal[i, 1]);
            }
            Console.ReadKey();
            Console.WriteLine("Partidos de las Semifinales:\n");
            //estos if sirven para validar cual de los dos equipos gano
            //y pasarlo a la lista de semifinal
            //habran cuatro juegos parecidos de if, que son de cada partido que se hizo
            //Partido #1
            if (cuartosFinal[0, 1] > cuartosFinal[1, 1])
            {
                semifinal[0, 0] = equipos[listNumbers[0] - 1, 0];
                semifinal[0, 1] = (int.Parse(equipos[listNumbers[0] - 1, 1]) + 1).ToString();
                semifinal[0, 2] = equipos[listNumbers[0] - 1, 2];
                semifinal[0, 3] = equipos[listNumbers[0] - 1, 3];

            }
            else if (cuartosFinal[0, 1] < cuartosFinal[1, 1])
            {
                semifinal[0, 0] = equipos[listNumbers[1] - 1, 0];
                semifinal[0, 1] = (int.Parse(equipos[listNumbers[1] - 1, 1]) + 1).ToString();
                semifinal[0, 2] = equipos[listNumbers[1] - 1, 2];
                semifinal[0, 3] = equipos[listNumbers[1] - 1, 3];
            }
            else if (cuartosFinal[0, 1] == cuartosFinal[1, 1])
            {
                //esta validacion es para ver si entre ellos quedaron empates
                //y pasara quien tenga mayor poder de equipo
                if (cuartosFinal[0, 0] > cuartosFinal[1, 0])
                {
                    semifinal[0, 0] = equipos[listNumbers[0] - 1, 0];
                    //aqui lo que hago es sumar uno a las victorias del equipo y como la lista
                    //es de tipo string, hice una pequeña vuelta, primero lo converti en tipo int o numero
                    //para sumar el 1, que es la victoria de los cuartos de final
                    //el 1 se pone afuera de la conversion del int y con parentisis, porque sino
                    //no suma la victoria, pero al estar asi, si lo suma
                    //y luego lo converti a string para que se pudiera guardar en la lista de semifinal
                    semifinal[0, 1] = (int.Parse(equipos[listNumbers[0] - 1, 1]) + 1).ToString();
                    semifinal[0, 2] = equipos[listNumbers[0] - 1, 2];
                    semifinal[0, 3] = equipos[listNumbers[0] - 1, 3];
                }
                else if (cuartosFinal[0, 0] < cuartosFinal[1, 0])
                {
                    semifinal[0, 0] = equipos[listNumbers[1] - 1, 0];
                    semifinal[0, 1] = (int.Parse(equipos[listNumbers[1] - 1, 1]) + 1).ToString();
                    semifinal[0, 2] = equipos[listNumbers[1] - 1, 2];
                    semifinal[0, 3] = equipos[listNumbers[1] - 1, 3];
                }
            }

            //Partido #2
            if (cuartosFinal[2, 1] > cuartosFinal[3, 1])
            {
                semifinal[1, 0] = equipos[listNumbers[2] - 1, 0];
                semifinal[1, 1] = (int.Parse(equipos[listNumbers[2] - 1, 1]) + 1).ToString();
                semifinal[1, 2] = equipos[listNumbers[2] - 1, 2];
                semifinal[1, 3] = equipos[listNumbers[2] - 1, 3];
            }
            else if (cuartosFinal[2, 1] < cuartosFinal[3, 1])
            {
                semifinal[1, 0] = equipos[listNumbers[3] - 1, 0];
                semifinal[1, 1] = (int.Parse(equipos[listNumbers[3] - 1, 1]) + 1).ToString();
                semifinal[1, 2] = equipos[listNumbers[3] - 1, 2];
                semifinal[1, 3] = equipos[listNumbers[3] - 1, 3];
            }
            else if (cuartosFinal[2, 1] == cuartosFinal[3, 1])
            {
                if (cuartosFinal[2, 0] > cuartosFinal[3, 0])
                {
                    semifinal[1, 0] = equipos[listNumbers[2] - 1, 0];
                    semifinal[1, 1] = (int.Parse(equipos[listNumbers[2] - 1, 1]) + 1).ToString();
                    semifinal[1, 2] = equipos[listNumbers[2] - 1, 2];
                    semifinal[1, 3] = equipos[listNumbers[2] - 1, 3];
                }
                else if (cuartosFinal[2, 0] < cuartosFinal[3, 0])
                {
                    semifinal[1, 0] = equipos[listNumbers[3] - 1, 0];
                    semifinal[1, 1] = (int.Parse(equipos[listNumbers[3] - 1, 1]) + 1).ToString();
                    semifinal[1, 2] = equipos[listNumbers[3] - 1, 2];
                    semifinal[1, 3] = equipos[listNumbers[3] - 1, 3];
                }
            }

            //Partido #3
            if (cuartosFinal[4, 1] > cuartosFinal[5, 1])
            {
                semifinal[2, 0] = equipos[listNumbers[4] - 1, 0];
                semifinal[2, 1] = (int.Parse(equipos[listNumbers[4] - 1, 1]) + 1).ToString();
                semifinal[2, 2] = equipos[listNumbers[4] - 1, 2];
                semifinal[2, 3] = equipos[listNumbers[4] - 1, 3];
            }
            else if (cuartosFinal[4, 1] < cuartosFinal[5, 1])
            {
                semifinal[2, 0] = equipos[listNumbers[5] - 1, 0];
                semifinal[2, 1] = (int.Parse(equipos[listNumbers[5] - 1, 1]) + 1).ToString();
                semifinal[2, 2] = equipos[listNumbers[5] - 1, 2];
                semifinal[2, 3] = equipos[listNumbers[5] - 1, 3];
            }
            else if (cuartosFinal[4, 1] == cuartosFinal[5, 1])
            {
                if (cuartosFinal[4, 0] > cuartosFinal[5, 0])
                {
                    semifinal[2, 0] = equipos[listNumbers[4] - 1, 0];
                    semifinal[2, 1] = (int.Parse(equipos[listNumbers[4] - 1, 1]) + 1).ToString();
                    semifinal[2, 2] = equipos[listNumbers[4] - 1, 2];
                    semifinal[2, 3] = equipos[listNumbers[4] - 1, 3];
                }
                else if (cuartosFinal[4, 0] < cuartosFinal[5, 0])
                {
                    semifinal[2, 0] = equipos[listNumbers[5] - 1, 0];
                    semifinal[2, 1] = (int.Parse(equipos[listNumbers[5] - 1, 1]) + 1).ToString();
                    semifinal[2, 2] = equipos[listNumbers[5] - 1, 2];
                    semifinal[2, 3] = equipos[listNumbers[5] - 1, 3];
                }
            }

            //Partido #4
            if (cuartosFinal[6, 1] > cuartosFinal[7, 1])
            {
                semifinal[3, 0] = equipos[listNumbers[6] - 1, 0];
                semifinal[3, 1] = (int.Parse(equipos[listNumbers[6] - 1, 1]) + 1).ToString();
                semifinal[3, 2] = equipos[listNumbers[6] - 1, 2];
                semifinal[3, 3] = equipos[listNumbers[6] - 1, 3];
            }
            else if (cuartosFinal[6, 1] < cuartosFinal[7, 1])
            {
                semifinal[3, 0] = equipos[listNumbers[7] - 1, 0];
                semifinal[3, 1] = (int.Parse(equipos[listNumbers[7] - 1, 1]) + 1).ToString();
                semifinal[3, 2] = equipos[listNumbers[7] - 1, 2];
                semifinal[3, 3] = equipos[listNumbers[7] - 1, 3];
            }
            else if (cuartosFinal[6, 1] == cuartosFinal[7, 1])
            {
                if (cuartosFinal[6, 0] > cuartosFinal[7, 0])
                {
                    semifinal[3, 0] = equipos[listNumbers[6] - 1, 0];
                    semifinal[3, 1] = (int.Parse(equipos[listNumbers[6] - 1, 1]) + 1).ToString();
                    semifinal[3, 2] = equipos[listNumbers[6] - 1, 2];
                    semifinal[3, 3] = equipos[listNumbers[6] - 1, 3];
                }
                else if (cuartosFinal[6, 0] < cuartosFinal[7, 0])
                {
                    semifinal[3, 0] = equipos[listNumbers[7] - 1, 0];
                    semifinal[3, 1] = (int.Parse(equipos[listNumbers[7] - 1, 1]) + 1).ToString();
                    semifinal[3, 2] = equipos[listNumbers[7] - 1, 2];
                    semifinal[3, 3] = equipos[listNumbers[7] - 1, 3];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(semifinal[i, 0]);
            }

            Console.WriteLine("Resultados de los partidos:\n");
            for (int i = 0; i < 4; i++)
            {
                poderEquipo = (Double.Parse(semifinal[i, 1]) * 0.7 - Double.Parse(semifinal[i, 2]) * 0.2 + Double.Parse(semifinal[i, 3]) * 0.1) / 5;
                semifinal[i, 4] = poderEquipo.ToString();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int oportunidadGol = 0; oportunidadGol < 6; oportunidadGol++)
                {
                    resultado = rand.NextDouble();
                    if (resultado < Double.Parse(semifinal[i, 4]))
                    {
                        golesFavor++;
                    }
                    semifinal[i, 5] = golesFavor.ToString();
                }
                golesFavor = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(semifinal[i, 0] + " - " + semifinal[i, 5]);
            }
            Console.ReadKey();

            Console.WriteLine("Partidos de la Final:\n");
            //Partido #1
            if (double.Parse(semifinal[0, 5]) > double.Parse(semifinal[1, 5]))
            {
                final[0, 0] = semifinal[0, 0];
                final[0, 1] = (int.Parse(semifinal[0, 1]) + 1).ToString();
                final[0, 2] = semifinal[0, 2];
                final[0, 3] = semifinal[0, 3];

            }
            else if (double.Parse(semifinal[0, 5]) < double.Parse(semifinal[1, 5]))
            {
                final[0, 0] = semifinal[1, 0];
                final[0, 1] = (int.Parse(semifinal[1, 1]) + 1).ToString();
                final[0, 2] = semifinal[1, 2];
                final[0, 3] = semifinal[1, 3];
            }
            else if (double.Parse(semifinal[0, 5]) == double.Parse(semifinal[1, 5]))
            {
                if (double.Parse(semifinal[0, 4]) > double.Parse(semifinal[1, 4]))
                {
                    final[0, 0] = semifinal[0, 0];
                    final[0, 1] = (int.Parse(semifinal[0, 1]) + 1).ToString();
                    final[0, 2] = semifinal[0, 2];
                    final[0, 3] = semifinal[0, 3];
                }
                else if (double.Parse(semifinal[0, 4]) < double.Parse(semifinal[1, 4]))
                {
                    final[0, 0] = semifinal[1, 0];
                    final[0, 1] = (int.Parse(semifinal[1, 1]) + 1).ToString();
                    final[0, 2] = semifinal[1, 2];
                    final[0, 3] = semifinal[1, 3];
                }
            }

            //Partido #2
            if (double.Parse(semifinal[2, 5]) > double.Parse(semifinal[3, 5]))
            {
                final[1, 0] = semifinal[2, 0];
                final[1, 1] = (int.Parse(semifinal[2, 1]) + 1).ToString();
                final[1, 2] = semifinal[2, 2];
                final[1, 3] = semifinal[2, 3];
            }
            else if (double.Parse(semifinal[2, 5]) < double.Parse(semifinal[3, 5]))
            {
                final[1, 0] = semifinal[3, 0];
                final[1, 1] = (int.Parse(semifinal[3, 1]) + 1).ToString();
                final[1, 2] = semifinal[3, 2];
                final[1, 3] = semifinal[3, 3];
            }
            else if (double.Parse(semifinal[2, 5]) == double.Parse(semifinal[3, 5]))
            {
                if (double.Parse(semifinal[2, 4]) > double.Parse(semifinal[3, 4]))
                {
                    semifinal[1, 0] = equipos[listNumbers[2] - 1, 0];
                    semifinal[1, 1] = (int.Parse(equipos[listNumbers[2] - 1, 1]) + 1).ToString();
                    semifinal[1, 2] = equipos[listNumbers[2] - 1, 2];
                    semifinal[1, 3] = equipos[listNumbers[2] - 1, 3];
                }
                else if (double.Parse(semifinal[2, 4]) < double.Parse(semifinal[3, 4]))
                {
                    final[1, 0] = semifinal[3, 0];
                    final[1, 1] = (int.Parse(semifinal[3, 1]) + 1).ToString();
                    final[1, 2] = semifinal[3, 2];
                    final[1, 3] = semifinal[3, 3];
                }
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(final[i, 0]);
            }

            Console.WriteLine("Resultados del partido:\n");
            for (int i = 0; i < 2; i++)
            {
                poderEquipo = (Double.Parse(final[i, 1]) * 0.7 - Double.Parse(final[i, 2]) * 0.2 + Double.Parse(final[i, 3]) * 0.1) / 6;
                final[i, 4] = poderEquipo.ToString();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int oportunidadGol = 0; oportunidadGol < 6; oportunidadGol++)
                {
                    resultado = rand.NextDouble();
                    if (resultado < Double.Parse(final[i, 4]))
                    {
                        golesFavor++;
                    }
                    final[i, 5] = golesFavor.ToString();
                }
                golesFavor = 0;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(final[i, 0] + " - " + final[i, 5]);
            }
            Console.ReadKey();
        }
    }
}
