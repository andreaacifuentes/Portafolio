// See https://aka.ms/new-console-template for more information
using System;
using T12P_AC_1221519;

class Program
{
    static int cantidaddeEquipos = 8;
    static Equipo[] equipos = new Equipo[cantidaddeEquipos];
    static Random random = new Random();
    static void mostrarEquipos()
    {
        int i = 0;
        int j = cantidaddeEquipos - 1;

        while (i < cantidaddeEquipos / 2)
        {
            Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);

            i++;
            j--;

        }
    }

    static int seleccionarGanador (int i, int j)
    {
        int x= random.Next(0,100);
        if (x > 50)
        {
            return j;
        }
        return i;
    }
    static void simulacion()
    {
        while (cantidaddeEquipos > 1)
        {
            int i = 0;
            int j = cantidaddeEquipos - 1;

            mostrarEquipos();
            Console.WriteLine("================");

            while (i < cantidaddeEquipos / 2)
            {
                Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);

                int x = seleccionarGanador(i, j);

                Equipo aux = equipos[i];
                equipos[i] = equipos[x];
                equipos[j] = aux;

                Console.WriteLine("Gano: " + equipos[i].nombre);

                i++;
                j--;

                Console.WriteLine("-----------");

            }
            cantidaddeEquipos = cantidaddeEquipos / 2;
        }
        Console.WriteLine("El equipo ganador del torneo es: " + equipos[0].nombre);
    }

    static void sortearEquipos()
    {
        for (int i = 0; i < cantidaddeEquipos; i++)
        {
            int x = random.Next(0, cantidaddeEquipos);
            Equipo aux = equipos[i];
            equipos[i] = equipos[x];
            equipos[x] = aux;

        }
    }

    static void Main(string[] arg)
    {
        for (int i = 0; i < equipos.Length; i++)
        {
            equipos[i] = new Equipo();
            equipos[i].nombre = "Equipo" + i;
        }

        sortearEquipos();
        simulacion();
    }
}
