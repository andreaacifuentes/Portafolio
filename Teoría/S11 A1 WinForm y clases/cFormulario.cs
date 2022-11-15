using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_1221519_S11_C1
{
    internal class cFormulario
    {
        string NombreCompleto, _nacionalidad, _genero, _carrera;
        int _edad;

        //Constructor 

        public cFormulario()
        {
            NombreCompleto = "";
            _nacionalidad = "";
            _genero = "";
            _carrera = "";
            _edad = 0;
        }
        //Metodo GET
        public string getNombrecCompleto()
        {
            return NombreCompleto; 
        }
        public string getnacionalidad()
        {
            return _nacionalidad;
        }
        public string getgenero()
        {
            return _genero;
        }
        public string getcarrera()
        {
            return _carrera;
        }
        public int getedad()
        {
            return _edad;
        }
            //Metodos SET
        public void setNombreCompleto(string nombrecompleto)
        {
            NombreCompleto = nombrecompleto;
        }
        public void setnacionalidad(string nacionalidad)
        {
            _nacionalidad= nacionalidad;
        }
        public void setgenero(string genero)
        {
            _genero= genero;
        }
        public void setcarrera(string carrera)
        {
            _carrera = carrera;
        }
        public void setedad(int edad)
        {
            _edad= edad;
        }
    }
}
