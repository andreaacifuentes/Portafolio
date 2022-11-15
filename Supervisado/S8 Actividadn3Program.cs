using System;

namespace semana8
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            C = 0;
            F = 0;
            Console.WriteLine("Ingrese una temperatura en grados Farenheit");
            SolicitarInfo();
            double resultado = CalculoTemperatura(F);

            Console.WriteLine("La temperatura en grados Celcius es: " + C.ToString());

            void SolicitarInfo()
            {
                F = Convert.ToDouble(Console.ReadLine());
            }

            double CalculoTemperatura(double Temp)
            {
                C = (F - 32) * 5 / 9;
                return C;
            }

            Console.ReadKey();
            
        }
    }
}
