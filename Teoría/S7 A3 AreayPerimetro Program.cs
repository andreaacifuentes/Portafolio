using System;

namespace AndreaC1221519
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double r, pi;
            double area;
            double b, h;
            double per;
            double a;
            //Asignar valores
            pi = System.Math.PI;
            r = 0;
            b = 0;
            h = 0;
            //Solicitar al usuario ingreso de valores
            Console.WriteLine("Ingrese un valor para el radio con decimales");
            //Llamando a un procedimiento
            solicitarDatos();
            double resultado = calculoArea(r);

            Console.WriteLine("El valor del área es " + area.ToString());

            Console.WriteLine("Ingrese el valor de la base del rectángulo");
            solicitarDat();
            Console.WriteLine("Ingrese el valor de la altura del rectángulo");
            solicitarDato();
            double res = calculoPer(b);
            double rest = calculoA(h);

            Console.WriteLine("El valor del perímetro del rectángulo es " + per.ToString());
            Console.WriteLine("el valor del área del rectángulo es " + a.ToString());
            //Metodos = dividos en funciones y procedimientos
            void solicitarDatos()
            {
                r = Convert.ToDouble(Console.ReadLine());
            }
            void solicitarDat()
            {
                b = Convert.ToDouble(Console.ReadLine());
            }
            void solicitarDato()
            {
                h = Convert.ToDouble(Console.ReadLine());
            }
            //Declarar funciones
            double calculoArea(double radio)
            {
                area = pi * Math.Pow(r, 2);
                return area;
            }
            double calculoPer(double b)
            {
                per = 2 * (b + h);
                return per;
            }
            double calculoA(double h)
            {
                a = b * h;
                return a;
            }
        }
    }
}
