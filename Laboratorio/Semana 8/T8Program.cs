// See https://aka.ms/new-console-template for more information
Console.WriteLine("T8_JMML_1308819");

Console.WriteLine("Ingrese un número entero ");
int número = Convert.ToInt32(Console.ReadLine());
long binario = decimalBinario(número);

Console.WriteLine("El número decimal " + binario + " es");

Console.ReadLine();

long decimalBinario(int número)
{
    long binario = 0;
    int Divisor = 2;
    long dígito = 0;

    for (int i = número % Divisor, j = 0; número > 0; número /=Divisor, i = número % Divisor, j++)
    {
        dígito = i % Divisor;
        binario += dígito * (long)Math.Pow(10, j);
    }
    return binario; 
}

Console.WriteLine("Ingrese un número entero");
int H = Convert.ToInt32(Console.ReadLine());
long hexa = decimalHexa(H);

Console.WriteLine("El número hexadecimal es " + hexa);
Console.ReadLine();

long decimalHexa(int H)
{
    long hexa = 0;
    int Div = 6;
    long dig = 0; 

    for (int i = H % Div, j = 0; H > 0; H/=Div, i = H % Div, j++)
    {
        dig = i % Div;
        hexa += dig * (long)Math.Pow(10, j);
    }
    return hexa;
}