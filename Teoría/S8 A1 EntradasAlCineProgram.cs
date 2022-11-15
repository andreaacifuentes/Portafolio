using System;

namespace Ejercicioenclase2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enunciado:
             * - Crear un programa que evalue edad de una persona y sepa si 
             * - es menor de 10 años su entrada es gratis 
             * - si es mayor de 10 y menor de 15 su entrada vale Q15.00 
             * - si es mayor de 15 y menor de 21 su entrada vale Q25.00 
             * - si es mayor de 21 su entrada vale Q35.00 
             * - si es de la tercera edad entra gratis 
             * - si es menor de 10 y menor de 15 puede ver pg13 y puede ver pg15 si es ta con 
             * - si es mayor de 15 puede ver PG15
             * - si es mayor de 21 úede ver todas, al igual si es mayor de edad 
             */

            // variables: edad, precio, clasificación 
            int _edad, _precio;
            string _clasificacion = "";
            string _adulto = "";

            Console.WriteLine("===== Bienvenidos al cine =====");
            Console.WriteLine("Ingrese su edad");
            _edad = Convert.ToInt32(Console.ReadLine());

            if (_edad < 10)
            {
                Console.WriteLine("El costo de la entrada es Q. 0.00");
            }
            else
            {
                if (_edad > 10 && _edad < 15)
                {
                    Console.WriteLine("Estás acompañado de un adulto? (Si/No)");
                    _adulto = Console.ReadLine().ToString();
                    if (_adulto.ToLower() == "si")
                    {
                        _clasificacion = "PG15";
                    }
                    else
                    {
                        _clasificacion = "PG13";
                    }
                    _precio = 15;
                    _clasificacion = "PG13";
                    Console.WriteLine("El costo de entrada es " + _precio + " y la clasificación es " + _clasificacion);
                }
                else
                {
                    if (_edad > 15 && _edad < 21)
                    {
                        _clasificacion = "PG15";
                        _precio = 25;

                        Console.WriteLine("El costo de la entrada es " + _precio + " y la clasificación es " + _clasificacion);
                    }
                    else
                    {
                        if (_edad > 21 && _edad < 60)
                        {
                            _clasificacion = "Todas";
                            _precio = 35;
                            Console.WriteLine("El costo de la entrada es " + _precio + " y la clasificación es " + _clasificacion);
                        }
                        else
                        {
                            if (_edad > 60)
                            {
                                _precio = 0;
                                _clasificacion = "Todas";
                                Console.WriteLine("El costo de la entrada es " + _precio + " y la clasificación es " + _clasificacion);
                            }
                        }
                    }
                }


            }
        }
    }
}
