using System;

namespace S9_LAB10_AC_1221519_Y_JM_1308819
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(2.45, 3.15, 4.67);

            int opcion;
            do
            {
                Console.WriteLine("Buenos días, seleccione una de las siguiente opciones: ");
                Console.WriteLine("1. El valor del Perímetro.");
                Console.WriteLine("2. El valor del Área.");
                Console.WriteLine("3. El valor del Volumen.");
                Console.WriteLine("0. Para salir.");
                opcion = int.Parse(Console.ReadLine());

                opciones(opcion, circulo);
            } while (opcion != 0);


            static void opciones(int opcion, Circulo circulo)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor del radio con decimales: ");
                        circulo.Perimetro = double.Parse(Console.ReadLine());
                        Console.WriteLine("El Perímetro con el radio ingresado es de: " + circulo.Perimetro1());
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el valor del radio con decimales: ");
                        circulo.area = double.Parse(Console.ReadLine());
                        Console.WriteLine("El Área con el radio ingresado es de: " + circulo.area1());
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el valor del radio con decimales: ");
                        circulo.volumen = double.Parse(Console.ReadLine());
                        Console.WriteLine("El Volumen con el readio ingresado es de: " + circulo.volumen1());
                        break;

                    case 0:
                        Console.WriteLine("Feliz día");
                        break;

                    default:
                        Console.WriteLine(opcion + " No es válido");
                        break;
                }
            }
        }
    }
}
