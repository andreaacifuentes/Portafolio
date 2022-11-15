// See https://aka.ms/new-console-template for more information
String lectura;
Console.WriteLine("Ingrese la oración, no ingrese palabras repetidas poi favoi");
lectura = Console.ReadLine();
string[] palabra = new string[lectura.Length];
string[] lista = new string[palabra.Length];
string[] resultado = new string[palabra.Length];

for (int i = 0; i < lista.Length; i++)
{
    int conteo = 0;
    for(int j = 0; j < palabra.Length; j++)
    {
        if (palabra[j] == lista[i])
        {
                            resultado[i]= palabra[j];
            conteo++;
            if (numero(lista[i]))
            {
                lista[i] = palabra[j];
                resultado[j] = palabra[j];

            }

        }

    }

    if (lista[i] != palabra[i])
    {
        Console.WriteLine(lista[i] + conteo);
    }

}

bool numero (string num)
{
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i]==num)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine("El resultado es: " + resultado);

Console.ReadKey();





