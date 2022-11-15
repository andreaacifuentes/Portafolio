using System;

namespace T1_AC_1221519
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            //Solicitud de datos
            Console.Write("Nombre: ");
            string sNombre = Console.ReadLine();
            Console.Write("Edad: ");
            int sEdad = int.Parse(Console.ReadLine());
            Console.Write("Carrera: ");
            string sCarrera = Console.ReadLine();
            Console.Write("Carné: ");
            int sCarne = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Soy " + sNombre + " tengo " + sEdad + " años y estudio la carrera de " + sCarrera + " mi número de carné es " + sCarne);
            Console.ReadKey();
        }
    }
}
