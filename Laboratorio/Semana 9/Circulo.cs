using System;
using System.Collections.Generic;
using System.Text;

namespace S9_LAB10_AC_1221519_Y_JM_1308819
{
    class Circulo
    {
        public double Perimetro;
        public double area;
        public double volumen;

        public Circulo(double Perimetro, double area, double volumen)
        {
            this.Perimetro = Perimetro;
            this.area = area;
            this.volumen = volumen;
        }
        public double Perimetro1()
        {
            return this.Perimetro * 2 * 3.1416;
        }
        public double area1()
        {
            return this.area * area * 3.1416;
        }
        public double volumen1()
        {
            return this.volumen * volumen * volumen * 4 * 3.1416 / 3;
        }
    }
}
