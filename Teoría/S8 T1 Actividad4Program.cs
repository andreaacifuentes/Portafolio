using System;

namespace AC_1221519_S8T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10, special;
            Console.WriteLine("Ingrese 10 palabras y al finalizar cada palabra dar enter");
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();
            string p3 = Console.ReadLine();
            string p4 = Console.ReadLine();
            string p5 = Console.ReadLine();
            string p6 = Console.ReadLine();
            string p7 = Console.ReadLine();
            string p8 = Console.ReadLine();
            string p9 = Console.ReadLine();
            string p10 = Console.ReadLine();

            sp1 = p1.ToUpper();
            sp2 = p2.ToUpper();
            sp3 = p3.ToUpper();
            sp4 = p4.ToUpper();
            sp5 = p5.ToUpper();
            sp6 = p6.ToUpper();
            sp7 = p7.ToUpper();
            sp8 = p8.ToUpper();
            sp9 = p9.ToUpper();
            sp10 = p10.ToUpper();



            if (sp1 == p1)
            {
                Console.WriteLine(p1 + " Es una palabra molesta");

            }

            if (sp2 == p2)
            {
                Console.WriteLine(p2 + " Es una palabra molesta");

            }

            if (sp3 == p3)
            {
                Console.WriteLine(p3 + " Es una palabra molesta");

            }

            if (sp4 == p4)
            {
                Console.WriteLine(p4 + " Es una palabra molesta");

            }
            else

            if (sp5 == p5)
            {
                Console.WriteLine(p5 + " Es una palabra molesta");

            }
            else

            if (sp6 == p6)
            {
                Console.WriteLine(p6 + " Es una palabra molesta");

            }

            if (sp7 == p7)
            {
                Console.WriteLine(p7 + " Es una palabra molesta");

            }

            if (sp8 == p8)
            {
                Console.WriteLine(p8 + " Es una palabra molesta");

            }

            if (sp9 == p9)
            {
                Console.WriteLine(p9 + " Es una palabra molesta");

            }

            if (sp10 == p10)
            {
                Console.WriteLine(p10 + " Es una palabra molesta");

            }


            string s1 = "!";
            string s2 = "?";
            bool a = p1.Contains(s1);
            bool b = p1.Contains(s2);
            bool c = p2.Contains(s1);
            bool d = p2.Contains(s2);
            bool e = p3.Contains(s1);
            bool f = p3.Contains(s2);
            bool g = p4.Contains(s1);
            bool h = p4.Contains(s2);
            bool i = p5.Contains(s1);
            bool j = p5.Contains(s2);
            if (a)
            {
                int index = p1.IndexOf(s1);
                if (index >= 0)
                    Console.WriteLine(p1 + "Contiene un caracter invalido",
                                  s1, index + 1);
            }
            if (b)
            {
                int index = p1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine(p1 + "Contiene un caracter invalido",
                                  s2, index + 1);
            }

            if (c)
            {
                int index = p2.IndexOf(s1);
                if (index >= 0)
                    Console.WriteLine(p2 + "Contiene un caracter invalido",
                                  s1, index + 1);
            }
            if (d)
            {
                int index = p2.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine(p2 + "Contiene un caracter invalido",
                                  s2, index + 1);
            }

            if (e)
            {
                int index = p3.IndexOf(s1);
                if (index >= 0)
                    Console.WriteLine(p3 + "Contiene un caracter invalido",
                                  s1, index + 1);
            }
            if (f)
            {
                int index = p3.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine(p3 + "Contiene un caracter invalido",
                                  s2, index + 1);
            }

            if (g)
            {
                int index = p4.IndexOf(s1);
                if (index >= 0)
                    Console.WriteLine(p4 + "Contiene un caracter invalido",
                                  s1, index + 1);
            }
            if (h)
            {
                int index = p4.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine(p4 + "Contiene un caracter invalido",
                                  s2, index + 1);
            }


            if (i)
            {
                int index = p5.IndexOf(s1);
                if (index >= 0)
                    Console.WriteLine(p5 + "Es una palabra molesta porque contiene un caracter invalido",
                                  s1, index + 1);
            }
            if (j)
            {
                int index = p5.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine(p5 + "Es una palabra molesta porque contiene un caracter invalido",
                                  s2, index + 1);
            }
            Console.ReadKey();

        }

    }

}
