// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Numerics;

int[] _vector;

int _cantidadDatos = 0;

Console.WriteLine("Ingrese cantidad");

_cantidadDatos = int.Parse(Console.ReadLine());

_vector = new int[_cantidadDatos];

int i = 0;
for (i = 0; i <= _cantidadDatos; i++)
{
    Console.WriteLine("ingrese un valor");
    _vector[i] = int.Parse(Console.ReadLine());
    Console.ReadKey();

    if (_vector[i]/2==0)
    {
        Console.WriteLine("Es un número par");
    }
    else
    {
        Console.WriteLine("Es un número impar");
    }
}

