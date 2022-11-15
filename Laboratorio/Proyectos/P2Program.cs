// See https://aka.ms/new-console-template for more information
namespace ProyectoEstampas
{
    class Program
    {
        public static string[,] catEspecial = new string[2, 30];
        public static string[,] Qat = new string[2, 19];
        public static string[,] Ecu = new string[2, 19];
        public static string[,] Sen = new string[2, 19];
        public static string[,] Ned = new string[2, 19];
        public static string[,] Eng = new string[2, 19];
        public static string[,] Irn = new string[2, 19];
        public static string[,] Usa = new string[2, 19];
        public static string[,] Wal = new string[2, 19];
        public static string[,] Arg = new string[2, 19];
        public static string[,] Ksa = new string[2, 19];
        public static string[,] Mex = new string[2, 19];
        public static string[,] Pol = new string[2, 19];
        public static string[,] Fra = new string[2, 19];
        public static string[,] Aus = new string[2, 19];
        public static string[,] Den = new string[2, 19];
        public static string[,] Tun = new string[2, 19];
        public static string[,] Esp = new string[2, 19];
        public static string[,] Crc = new string[2, 19];
        public static string[,] Ger = new string[2, 19];
        public static string[,] Jpn = new string[2, 19];
        public static string[,] Bel = new string[2, 19];
        public static string[,] Can = new string[2, 19];
        public static string[,] Mar = new string[2, 19];
        public static string[,] Cro = new string[2, 19];
        public static string[,] Bra = new string[2, 19];
        public static string[,] Srb = new string[2, 19];
        public static string[,] Sui = new string[2, 19];
        public static string[,] Cmr = new string[2, 19];
        public static string[,] Por = new string[2, 19];
        public static string[,] Gha = new string[2, 19];
        public static string[,] Uru = new string[2, 19];
        public static string[,] Kor = new string[2, 19];
        static void Main(string[] args)
        {
            llenarDatos();
            menu();

        }

        public static void llenarDatos()
        {
            string nombre;
            for (int i = 0; i < 30; i++)
            {
                nombre = "FWC" + i;
                catEspecial[0, i] = nombre;
                catEspecial[1, i] = "Faltante";
            }

            for (int i = 0; i < 32; i++)
            {
                for (int numeroEstampa = 0; numeroEstampa < 19; numeroEstampa++)
                {
                    if (i == 0)
                    {
                        nombre = "QAT" + (numeroEstampa + 1);
                        Qat[0, numeroEstampa] = nombre;
                        Qat[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 1)
                    {
                        nombre = "ECU" + (numeroEstampa + 1);
                        Ecu[0, numeroEstampa] = nombre;
                        Ecu[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 2)
                    {
                        nombre = "SEN" + (numeroEstampa + 1);
                        Sen[0, numeroEstampa] = nombre;
                        Sen[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 3)
                    {
                        nombre = "NED" + (numeroEstampa + 1);
                        Ned[0, numeroEstampa] = nombre;
                        Ned[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 4)
                    {
                        nombre = "ENG" + (numeroEstampa + 1);
                        Eng[0, numeroEstampa] = nombre;
                        Eng[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 5)
                    {
                        nombre = "IRN" + (numeroEstampa + 1);
                        Irn[0, numeroEstampa] = nombre;
                        Irn[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 6)
                    {
                        nombre = "USA" + (numeroEstampa + 1);
                        Usa[0, numeroEstampa] = nombre;
                        Usa[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 7)
                    {
                        nombre = "WAL" + (numeroEstampa + 1);
                        Wal[0, numeroEstampa] = nombre;
                        Wal[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 8)
                    {
                        nombre = "ARG" + (numeroEstampa + 1);
                        Arg[0, numeroEstampa] = nombre;
                        Arg[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 9)
                    {
                        nombre = "KSA" + (numeroEstampa + 1);
                        Ksa[0, numeroEstampa] = nombre;
                        Ksa[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 10)
                    {
                        nombre = "MEX" + (numeroEstampa + 1);
                        Mex[0, numeroEstampa] = nombre;
                        Mex[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 11)
                    {
                        nombre = "POL" + (numeroEstampa + 1);
                        Pol[0, numeroEstampa] = nombre;
                        Pol[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 12)
                    {
                        nombre = "FRA" + (numeroEstampa + 1);
                        Fra[0, numeroEstampa] = nombre;
                        Fra[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 13)
                    {
                        nombre = "AUS" + (numeroEstampa + 1);
                        Aus[0, numeroEstampa] = nombre;
                        Aus[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 14)
                    {
                        nombre = "DEN" + (numeroEstampa + 1);
                        Den[0, numeroEstampa] = nombre;
                        Den[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 15)
                    {
                        nombre = "TUN" + (numeroEstampa + 1);
                        Tun[0, numeroEstampa] = nombre;
                        Tun[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 16)
                    {
                        nombre = "ESP" + (numeroEstampa + 1);
                        Esp[0, numeroEstampa] = nombre;
                        Esp[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 17)
                    {
                        nombre = "CRC" + (numeroEstampa + 1);
                        Crc[0, numeroEstampa] = nombre;
                        Crc[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 18)
                    {
                        nombre = "GER" + (numeroEstampa + 1);
                        Ger[0, numeroEstampa] = nombre;
                        Ger[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 19)
                    {
                        nombre = "JPN" + (numeroEstampa + 1);
                        Jpn[0, numeroEstampa] = nombre;
                        Jpn[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 20)
                    {
                        nombre = "BEL" + (numeroEstampa + 1);
                        Bel[0, numeroEstampa] = nombre;
                        Bel[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 21)
                    {
                        nombre = "CAN" + (numeroEstampa + 1);
                        Can[0, numeroEstampa] = nombre;
                        Can[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 22)
                    {
                        nombre = "MAR" + (numeroEstampa + 1);
                        Mar[0, numeroEstampa] = nombre;
                        Mar[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 23)
                    {
                        nombre = "CRO" + (numeroEstampa + 1);
                        Cro[0, numeroEstampa] = nombre;
                        Cro[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 24)
                    {
                        nombre = "BRA" + (numeroEstampa + 1);
                        Bra[0, numeroEstampa] = nombre;
                        Bra[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 25)
                    {
                        nombre = "SRB" + (numeroEstampa + 1);
                        Srb[0, numeroEstampa] = nombre;
                        Srb[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 26)
                    {
                        nombre = "SUI" + (numeroEstampa + 1);
                        Sui[0, numeroEstampa] = nombre;
                        Sui[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 27)
                    {
                        nombre = "CMR" + (numeroEstampa + 1);
                        Cmr[0, numeroEstampa] = nombre;
                        Cmr[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 28)
                    {
                        nombre = "POR" + (numeroEstampa + 1);
                        Por[0, numeroEstampa] = nombre;
                        Por[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 29)
                    {
                        nombre = "GHA" + (numeroEstampa + 1);
                        Gha[0, numeroEstampa] = nombre;
                        Gha[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 30)
                    {
                        nombre = "URU" + (numeroEstampa + 1);
                        Uru[0, numeroEstampa] = nombre;
                        Uru[1, numeroEstampa] = "Faltante";
                    }
                    else if (i == 31)
                    {
                        nombre = "KOR" + (numeroEstampa + 1);
                        Kor[0, numeroEstampa] = nombre;
                        Kor[1, numeroEstampa] = "Faltante";
                    }
                }
            }
        }

        public static void menu()
        {
            int eleccion;
            Console.WriteLine("Bienvenido a la app de Stickers del album Panini Qatar 2022");
            Console.WriteLine("Elija una de las siguientes opciones:");
            Console.WriteLine("1) Comprobar estado actual de las estampas");
            Console.WriteLine("2) Ver Estampas Faltantes");
            Console.WriteLine("3) Ver Estampas Marcadas");
            Console.WriteLine("4) Ver Estampas Repetidas");
            Console.WriteLine("0) Salir");
            eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.Clear();
                    cambiarEstado();
                    break;
                case 2:
                    Console.Clear();
                    estampasFaltantes();
                    break;
                case 3:
                    Console.Clear();
                    estampasMarcadas();
                    break;
                case 4:
                    Console.Clear();
                    estampasRepetidas();
                    break;
                case 0:
                    Console.WriteLine("Feliz día");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Ha elegido una opcion incorrecta, Porfavor vuelva a ingresarlo\n");
                    menu();
                    break;
            }
        }

        public static void cambiarEstado()
        {
            string pais, eleccion;
            int numeroJugador = 0;
            Console.WriteLine("Ingrese el nombre del pais que quiere revisar");
            pais = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de jugador que quiere cambiar");
            numeroJugador = int.Parse(Console.ReadLine());
            while (numeroJugador >= 20 || numeroJugador <= 0)
            {
                Console.WriteLine("El numero ingresado es incorrecto, porfavor\nIngrese el numero de jugador que quiere cambiar");
                numeroJugador = int.Parse(Console.ReadLine());
            }
            //esto lo hicimos para que el nombre que eliga se vuelva por completo  en minusculas
            switch (pais.ToLower())
            {
                case "qatar":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Qat[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "ecuador":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Ecu[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "senegal":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Sen[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "holanda":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Ned[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "inglaterra":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Eng[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "iran":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Irn[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "estados unidos":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Usa[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "gales":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Wal[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "argentina":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Arg[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "arabia saudita":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Ksa[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "mexico":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Mex[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "polonia":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Pol[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "francia":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Fra[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "australia":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Aus[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "dinamarca":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Den[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "tunez":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Tun[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "españa":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Esp[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "costa rica":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Crc[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "alemania":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Ger[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "japon":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Jpn[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "belgica":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Bel[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "canada":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Can[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "marruecos":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Mar[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "croacia":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Cro[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "brasil":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Bra[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "serbia":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Srb[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "suiza":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Sui[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "camerun":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Cmr[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "portugal":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Por[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "ghana":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Gha[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "uruguay":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Uru[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                case "corea del sur":
                    Console.WriteLine("Ingrese como desea marcar la siguiente estampa: Faltante, Marcada o Repetida");
                    eleccion = Console.ReadLine();
                    if (eleccion.ToLower().Equals("faltante") || eleccion.ToLower().Equals("marcada") || eleccion.ToLower().Equals("repetida"))
                    {
                        Kor[1, numeroJugador - 1] = eleccion;
                        Console.Clear();
                        Console.WriteLine("La estampa ha sido cambiada exitosamente\n");
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Has ingresado un nombre incorrecto para el estado\nIngrese nuevamente los datos\n");
                        cambiarEstado();
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Has ingresado un nombre incorrecto para el equipo\nIngrese nuevamente los datos\n");
                    cambiarEstado();
                    break;
            }
        }
        public static void estampasFaltantes()
        {
            Console.WriteLine("Estas son las estampas faltantes en tu album:\nCategoria de Especiales");
            for (int i = 0; i < 30; i++)
            {
                if (catEspecial[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + catEspecial[0, i]);
                }
            }
            Console.WriteLine("\nGrupo A\nQatar");
            for (int i = 0; i < 19; i++)
            {
                if (Qat[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Qat[0, i]);
                }
            }
            Console.WriteLine("\nEcuador");
            for (int i = 0; i < 19; i++)
            {
                if (Ecu[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ecu[0, i]);
                }
            }
            Console.WriteLine("\nSenegal");
            for (int i = 0; i < 19; i++)
            {
                if (Sen[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sen[0, i]);
                }
            }
            Console.WriteLine("\nHolanda");
            for (int i = 0; i < 19; i++)
            {
                if (Ned[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ned[0, i]);
                }
            }
            Console.WriteLine("\nGrupo B\nInglaterra");
            for (int i = 0; i < 19; i++)
            {
                if (Eng[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Eng[0, i]);
                }
            }
            Console.WriteLine("\nIran");
            for (int i = 0; i < 19; i++)
            {
                if (Irn[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Irn[0, i]);
                }
            }
            Console.WriteLine("\nEstados Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Usa[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Usa[0, i]);
                }
            }
            Console.WriteLine("\nGales");
            for (int i = 0; i < 19; i++)
            {
                if (Wal[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Wal[0, i]);
                }
            }
            Console.WriteLine("\nGrupo C\nArgentina");
            for (int i = 0; i < 19; i++)
            {
                if (Arg[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Arg[0, i]);
                }
            }
            Console.WriteLine("\nEmiratos Arabes Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Ksa[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ksa[0, i]);
                }
            }
            Console.WriteLine("\nMexico");
            for (int i = 0; i < 19; i++)
            {
                if (Mex[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mex[0, i]);
                }
            }
            Console.WriteLine("\nPolonia");
            for (int i = 0; i < 19; i++)
            {
                if (Pol[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Pol[0, i]);
                }
            }
            Console.WriteLine("\nGrupo D\nFrancia");
            for (int i = 0; i < 19; i++)
            {
                if (Fra[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Fra[0, i]);
                }
            }
            Console.WriteLine("\nAustralia");
            for (int i = 0; i < 19; i++)
            {
                if (Aus[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Aus[0, i]);
                }
            }
            Console.WriteLine("\nDinamarca");
            for (int i = 0; i < 19; i++)
            {
                if (Den[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Den[0, i]);
                }
            }
            Console.WriteLine("\nTunez");
            for (int i = 0; i < 19; i++)
            {
                if (Tun[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Tun[0, i]);
                }
            }
            Console.WriteLine("\nGrupo E\nEspaña");
            for (int i = 0; i < 19; i++)
            {
                if (Esp[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Esp[0, i]);
                }
            }
            Console.WriteLine("\nCosta Rica");
            for (int i = 0; i < 19; i++)
            {
                if (Crc[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Crc[0, i]);
                }
            }
            Console.WriteLine("\nAlemania");
            for (int i = 0; i < 19; i++)
            {
                if (Ger[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ger[0, i]);
                }
            }
            Console.WriteLine("\nJapon");
            for (int i = 0; i < 19; i++)
            {
                if (Jpn[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Jpn[0, i]);
                }
            }
            Console.WriteLine("\nGrupo F\nBelgica");
            for (int i = 0; i < 19; i++)
            {
                if (Bel[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bel[0, i]);
                }
            }
            Console.WriteLine("\nCanada");
            for (int i = 0; i < 19; i++)
            {
                if (Can[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Can[0, i]);
                }
            }
            Console.WriteLine("\nMarruecos");
            for (int i = 0; i < 19; i++)
            {
                if (Mar[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mar[0, i]);
                }
            }
            Console.WriteLine("\nCroacia");
            for (int i = 0; i < 19; i++)
            {
                if (Cro[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cro[0, i]);
                }
            }
            Console.WriteLine("\nGrupo G\nBrasil");
            for (int i = 0; i < 19; i++)
            {
                if (Bra[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bra[0, i]);
                }
            }
            Console.WriteLine("\nSerbia");
            for (int i = 0; i < 19; i++)
            {
                if (Srb[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Srb[0, i]);
                }
            }
            Console.WriteLine("\nSuiza");
            for (int i = 0; i < 19; i++)
            {
                if (Sui[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sui[0, i]);
                }
            }
            Console.WriteLine("\nCamerun");
            for (int i = 0; i < 19; i++)
            {
                if (Cmr[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cmr[0, i]);
                }
            }
            Console.WriteLine("\nGrupo H\nPortugal");
            for (int i = 0; i < 19; i++)
            {
                if (Por[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Por[0, i]);
                }
            }
            Console.WriteLine("\nGhana");
            for (int i = 0; i < 19; i++)
            {
                if (Gha[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Gha[0, i]);
                }
            }
            Console.WriteLine("\nUruguay");
            for (int i = 0; i < 19; i++)
            {
                if (Uru[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Uru[0, i]);
                }
            }
            Console.WriteLine("\nCorea del Sur");
            for (int i = 0; i < 19; i++)
            {
                if (Kor[1, i].Equals("Faltante"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Kor[0, i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
            menu();
        }
        public static void estampasMarcadas()
        {
            Console.WriteLine("Estas son las estampas marcadas en tu album:\nCategoria de Especiales");
            for (int i = 0; i < 30; i++)
            {
                if (catEspecial[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + catEspecial[0, i]);
                }
            }
            Console.WriteLine("\nGrupo A\nQatar");
            for (int i = 0; i < 19; i++)
            {
                if (Qat[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Qat[0, i]);
                }
            }
            Console.WriteLine("\nEcuador");
            for (int i = 0; i < 19; i++)
            {
                if (Ecu[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ecu[0, i]);
                }
            }
            Console.WriteLine("\nSenegal");
            for (int i = 0; i < 19; i++)
            {
                if (Sen[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sen[0, i]);
                }
            }
            Console.WriteLine("\nHolanda");
            for (int i = 0; i < 19; i++)
            {
                if (Ned[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ned[0, i]);
                }
            }
            Console.WriteLine("\nGrupo B\nInglaterra");
            for (int i = 0; i < 19; i++)
            {
                if (Eng[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Eng[0, i]);
                }
            }
            Console.WriteLine("\nIran");
            for (int i = 0; i < 19; i++)
            {
                if (Irn[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Irn[0, i]);
                }
            }
            Console.WriteLine("\nEstados Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Usa[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Usa[0, i]);
                }
            }
            Console.WriteLine("\nGales");
            for (int i = 0; i < 19; i++)
            {
                if (Wal[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Wal[0, i]);
                }
            }
            Console.WriteLine("\nGrupo C\nArgentina");
            for (int i = 0; i < 19; i++)
            {
                if (Arg[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Arg[0, i]);
                }
            }
            Console.WriteLine("\nEmiratos Arabes Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Ksa[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ksa[0, i]);
                }
            }
            Console.WriteLine("\nMexico");
            for (int i = 0; i < 19; i++)
            {
                if (Mex[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mex[0, i]);
                }
            }
            Console.WriteLine("\nPolonia");
            for (int i = 0; i < 19; i++)
            {
                if (Pol[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Pol[0, i]);
                }
            }
            Console.WriteLine("\nGrupo D\nFrancia");
            for (int i = 0; i < 19; i++)
            {
                if (Fra[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Fra[0, i]);
                }
            }
            Console.WriteLine("\nAustralia");
            for (int i = 0; i < 19; i++)
            {
                if (Aus[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Aus[0, i]);
                }
            }
            Console.WriteLine("\nDinamarca");
            for (int i = 0; i < 19; i++)
            {
                if (Den[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Den[0, i]);
                }
            }
            Console.WriteLine("\nTunez");
            for (int i = 0; i < 19; i++)
            {
                if (Tun[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Tun[0, i]);
                }
            }
            Console.WriteLine("\nGrupo E\nEspaña");
            for (int i = 0; i < 19; i++)
            {
                if (Esp[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Esp[0, i]);
                }
            }
            Console.WriteLine("\nCosta Rica");
            for (int i = 0; i < 19; i++)
            {
                if (Crc[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Crc[0, i]);
                }
            }
            Console.WriteLine("\nAlemania");
            for (int i = 0; i < 19; i++)
            {
                if (Ger[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ger[0, i]);
                }
            }
            Console.WriteLine("\nJapon");
            for (int i = 0; i < 19; i++)
            {
                if (Jpn[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Jpn[0, i]);
                }
            }
            Console.WriteLine("\nGrupo F\nBelgica");
            for (int i = 0; i < 19; i++)
            {
                if (Bel[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bel[0, i]);
                }
            }
            Console.WriteLine("\nCanada");
            for (int i = 0; i < 19; i++)
            {
                if (Can[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Can[0, i]);
                }
            }
            Console.WriteLine("\nMarruecos");
            for (int i = 0; i < 19; i++)
            {
                if (Mar[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mar[0, i]);
                }
            }
            Console.WriteLine("\nCroacia");
            for (int i = 0; i < 19; i++)
            {
                if (Cro[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cro[0, i]);
                }
            }
            Console.WriteLine("\nGrupo G\nBrasil");
            for (int i = 0; i < 19; i++)
            {
                if (Bra[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bra[0, i]);
                }
            }
            Console.WriteLine("\nSerbia");
            for (int i = 0; i < 19; i++)
            {
                if (Srb[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Srb[0, i]);
                }
            }
            Console.WriteLine("\nSuiza");
            for (int i = 0; i < 19; i++)
            {
                if (Sui[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sui[0, i]);
                }
            }
            Console.WriteLine("\nCamerun");
            for (int i = 0; i < 19; i++)
            {
                if (Cmr[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cmr[0, i]);
                }
            }
            Console.WriteLine("\nGrupo H\nPortugal");
            for (int i = 0; i < 19; i++)
            {
                if (Por[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Por[0, i]);
                }
            }
            Console.WriteLine("\nGhana");
            for (int i = 0; i < 19; i++)
            {
                if (Gha[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Gha[0, i]);
                }
            }
            Console.WriteLine("\nUruguay");
            for (int i = 0; i < 19; i++)
            {
                if (Uru[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Uru[0, i]);
                }
            }
            Console.WriteLine("\nCorea del Sur");
            for (int i = 0; i < 19; i++)
            {
                if (Kor[1, i].Equals("Marcada"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Kor[0, i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
            menu();
        }
        public static void estampasRepetidas()
        {
            Console.WriteLine("Estas son las estampas repetidas en tu album:\nCategoria de Especiales");
            for (int i = 0; i < 30; i++)
            {
                if (catEspecial[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + catEspecial[0, i]);
                }
            }
            Console.WriteLine("\nGrupo A\nQatar");
            for (int i = 0; i < 19; i++)
            {
                if (Qat[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Qat[0, i]);
                }
            }
            Console.WriteLine("\nEcuador");
            for (int i = 0; i < 19; i++)
            {
                if (Ecu[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ecu[0, i]);
                }
            }
            Console.WriteLine("\nSenegal");
            for (int i = 0; i < 19; i++)
            {
                if (Sen[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sen[0, i]);
                }
            }
            Console.WriteLine("\nHolanda");
            for (int i = 0; i < 19; i++)
            {
                if (Ned[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ned[0, i]);
                }
            }
            Console.WriteLine("\nGrupo B\nInglaterra");
            for (int i = 0; i < 19; i++)
            {
                if (Eng[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Eng[0, i]);
                }
            }
            Console.WriteLine("\nIran");
            for (int i = 0; i < 19; i++)
            {
                if (Irn[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Irn[0, i]);
                }
            }
            Console.WriteLine("\nEstados Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Usa[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Usa[0, i]);
                }
            }
            Console.WriteLine("\nGales");
            for (int i = 0; i < 19; i++)
            {
                if (Wal[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Wal[0, i]);
                }
            }
            Console.WriteLine("\nGrupo C\nArgentina");
            for (int i = 0; i < 19; i++)
            {
                if (Arg[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Arg[0, i]);
                }
            }
            Console.WriteLine("\nEmiratos Arabes Unidos");
            for (int i = 0; i < 19; i++)
            {
                if (Ksa[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ksa[0, i]);
                }
            }
            Console.WriteLine("\nMexico");
            for (int i = 0; i < 19; i++)
            {
                if (Mex[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mex[0, i]);
                }
            }
            Console.WriteLine("\nPolonia");
            for (int i = 0; i < 19; i++)
            {
                if (Pol[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Pol[0, i]);
                }
            }
            Console.WriteLine("\nGrupo D\nFrancia");
            for (int i = 0; i < 19; i++)
            {
                if (Fra[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Fra[0, i]);
                }
            }
            Console.WriteLine("\nAustralia");
            for (int i = 0; i < 19; i++)
            {
                if (Aus[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Aus[0, i]);
                }
            }
            Console.WriteLine("\nDinamarca");
            for (int i = 0; i < 19; i++)
            {
                if (Den[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Den[0, i]);
                }
            }
            Console.WriteLine("\nTunez");
            for (int i = 0; i < 19; i++)
            {
                if (Tun[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Tun[0, i]);
                }
            }
            Console.WriteLine("\nGrupo E\nEspaña");
            for (int i = 0; i < 19; i++)
            {
                if (Esp[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Esp[0, i]);
                }
            }
            Console.WriteLine("\nCosta Rica");
            for (int i = 0; i < 19; i++)
            {
                if (Crc[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Crc[0, i]);
                }
            }
            Console.WriteLine("\nAlemania");
            for (int i = 0; i < 19; i++)
            {
                if (Ger[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Ger[0, i]);
                }
            }
            Console.WriteLine("\nJapon");
            for (int i = 0; i < 19; i++)
            {
                if (Jpn[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Jpn[0, i]);
                }
            }
            Console.WriteLine("\nGrupo F\nBelgica");
            for (int i = 0; i < 19; i++)
            {
                if (Bel[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bel[0, i]);
                }
            }
            Console.WriteLine("\nCanada");
            for (int i = 0; i < 19; i++)
            {
                if (Can[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Can[0, i]);
                }
            }
            Console.WriteLine("\nMarruecos");
            for (int i = 0; i < 19; i++)
            {
                if (Mar[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Mar[0, i]);
                }
            }
            Console.WriteLine("\nCroacia");
            for (int i = 0; i < 19; i++)
            {
                if (Cro[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cro[0, i]);
                }
            }
            Console.WriteLine("\nGrupo G\nBrasil");
            for (int i = 0; i < 19; i++)
            {
                if (Bra[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Bra[0, i]);
                }
            }
            Console.WriteLine("\nSerbia");
            for (int i = 0; i < 19; i++)
            {
                if (Srb[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Srb[0, i]);
                }
            }
            Console.WriteLine("\nSuiza");
            for (int i = 0; i < 19; i++)
            {
                if (Sui[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Sui[0, i]);
                }
            }
            Console.WriteLine("\nCamerun");
            for (int i = 0; i < 19; i++)
            {
                if (Cmr[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Cmr[0, i]);
                }
            }
            Console.WriteLine("\nGrupo H\nPortugal");
            for (int i = 0; i < 19; i++)
            {
                if (Por[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Por[0, i]);
                }
            }
            Console.WriteLine("\nGhana");
            for (int i = 0; i < 19; i++)
            {
                if (Gha[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Gha[0, i]);
                }
            }
            Console.WriteLine("\nUruguay");
            for (int i = 0; i < 19; i++)
            {
                if (Uru[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Uru[0, i]);
                }
            }
            Console.WriteLine("\nCorea del Sur");
            for (int i = 0; i < 19; i++)
            {
                if (Kor[1, i].Equals("Repetida"))
                {
                    Console.WriteLine((i + 1) + ")" + " " + Kor[0, i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
            menu();
        }
    }
}
