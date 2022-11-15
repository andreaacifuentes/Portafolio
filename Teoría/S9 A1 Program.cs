using System;

namespace AC_1221519_T4_S9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            String[] aPalabras = { "HOLA", "Casa", "carro", "LAPIZ", "uno", "nuevo", "Siete", "OCHO", "nueve", "DIEZ" };
            for (int inc=0; inc <10; inc++)
            {
                Console.WriteLine("Validano mayúsculas..." + aPalabras[inc]);
                if (aPalabras[inc].ToUpper() == aPalabras[inc])
                {
                    Console.WriteLine("La palabra: " + aPalabras[inc] + " es mayúscula. ");
                }
            }
            static bool esMayuscula (string input)
            {
                for (int i = 0; 1 < input.Length; i++)
                {
                    if (!Char.IsUpper(input[i]))
                        return false;
                }
                return true;
            }
        }
    }
}
