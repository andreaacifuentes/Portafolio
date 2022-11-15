// See https://aka.ms/new-console-template for more information
Console.WriteLine("Combinaciones");
Console.ReadKey();
Console.Clear();
string[] letras = { "a", "e", "i", "o", "u" };
string[] numeros = { "1", "2", "3", "4", "5" };

int a, b;
string combinacion;
for (a = 0; a < letras.Length; a++)
{
    for (b = 0; b < numeros.Length; b++)
    {
        if (a != b)
        {
            combinacion = letras[a].ToString() + numeros[b].ToString();
            Console.WriteLine(combinacion);
        }
    }
}
for (a = 0; a < letras.Length; a++)
{
    for (b = 0; b < numeros.Length; b++)
    {
        if (a == b)
        {
            combinacion = letras[a].ToString() + numeros[b].ToString();
            Console.WriteLine(combinacion);
        }
    }
}
Console.ReadLine();
