// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio Carita");
imprimirFigura();
// Declara Variables 
string circulo;
string cir1;
string rectangulo;
string triangulo;

void crearCir1()
{
    cir1 = "         *****************************  \n" +
                 "     ****                             **** \n" +
                 "    ***                                  *** \n"+
                 "    **                                    ** \n";
    Console.WriteLine(cir1);
}
void crearRectangulo()
{
    rectangulo = "    **      ************************     **\n" +
                 "     **     ************************    **";
    Console.WriteLine(rectangulo);
}


//Salto "\n"

void crearTringulo()
{
    triangulo = "    **        *                   *       **\n" +
                "    **       * *                 * *      **\n" +
                "    **      *   *               *   *     **\n" +
                "    **     *     *             *     *    **\n" +
                "    **    *********           *********   **\n";
    Console.WriteLine(triangulo);
}
void crearCirculo()
{
    circulo = "      **                               ** \n " + 
              "      ***                           *** \n" +
              "       ****                         **** \n" +
              "         ***************************** \n";
        Console.WriteLine(circulo);
}

void imprimirFigura()
{
    crearCir1();
    crearTringulo();
    crearRectangulo();
    crearCirculo();
}


Console.ReadKey();
