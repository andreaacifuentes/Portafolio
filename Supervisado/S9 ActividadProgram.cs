using System;

namespace Semana9_AC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa en el cual:
             * A calificaciones mayores o igual a 90
             * B para calificaciones entre 80 y 89 
             * C para calificaciones entre 70 y 79 
             * D para calificaciones entre 60 y 69 
             * E para calificaciones entre 50 y 59 
             * F para calificaciones entre 0 y 49*/
          
            Console.WriteLine("Ingrese la calificación del usuario");
            int i = int.Parse(Console.ReadLine());

            if (i >= 90)
            {
                Console.WriteLine("Ha obtenido A de calificación");
            }
            else
            {
                if (i<=89 && i >= 80)
                {
                    Console.WriteLine("Ha obtenido B de calificación");
                }
                else
                {
                    if (i<=79 && i >= 70)
                    {
                        Console.WriteLine("Ha obtenido C de calificación");
                    }
                    else
                    {
                        if (i<=69 && i>=60)
                        {
                            Console.WriteLine("Ha obtenido D de calificación");
                        }
                        else
                        {
                            if (i<=59 && i >= 50)
                            {
                                Console.WriteLine("Ha obtenido E de calificación");
                            }
                            else
                            {
                                Console.WriteLine("Ha obtenido F de calificación");
                            }
                          
                        }
                    }
                }
            }
        }
    }
}
