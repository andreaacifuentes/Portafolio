using System;

namespace ejerciciobool
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese el primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Verdadero");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Falso");
                Console.ReadKey();
            }
        }
    }
}
