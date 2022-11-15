using System;

namespace T7_AC_1221519_Y_JM_1308819
{
    class Program
    {
        static void Main(string[] args)
        {
            double ope1, ope2, k, divisor, expo;
            int resultado;
            divisor = 1;
            expo = 1;
            k = 1;


            Console.WriteLine("Inciso A 1+1/n");
            Console.WriteLine("Ingrese valor de N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de n");
            double n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de x");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese valor de a");
            double a = int.Parse(Console.ReadLine());


            do
            {
                ope1 = 1 + (1 / divisor);
                divisor = 1 + divisor;

            } while (ope1 <= N);
            Console.WriteLine("El resultado es: " + ope1);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Inciso B 1+1^n");
            do
            {
                ope2 = 1 + Math.Pow(1, expo);
                expo = 1 + expo;
                Console.WriteLine("El resultado es: " + ope2);

            } while (ope2 <= N);
            Console.WriteLine("El resultado es: " + ope2);
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("Inciso C");
                resultado = (int)Math.Pow(x, k) * (int)Math.Pow(a, (n - k));
                k = k++;

            } while (k <= n);
            Console.WriteLine(resultado);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
