using System;

namespace L1_AC_1221519
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando datos
            Console.Write("Ingrese su nombre: ");
            //Declarando variables
            string Nombre = Console.ReadLine();

            Console.WriteLine("Hola mundo");
            Console.WriteLine("soy " + Nombre);

            //*WriteLine imprime el texto e inmediatamente crea una nueva línea, mientras que write solo imprime texto

            Console.Write("Hola mundo");
            Console.Write(" Soy " +Nombre);
            Console.ReadKey();
        }
    }
}
