using System;

public class cAutomovil
{
	public cAutomovil()
	{
        //Atributos = caracteristicas de la clase (se traducen en variables)
        string _modelo, _marca, _year, _color, _tipo, _tipoCombustible, _transmision;
        bool _es4x4;

        string mensajeGasolina, mensajeEncendido, mensajeCambioLLanta, colorNuevo, fasePintura, mensajeCambioPintura;
        bool comprarLlanta, cambiarColor, cambiarPintura;

        //Constructor = Instanciar la clase desde fuera.
        //Al crear un objeto de la clase se pueden instanciar a cero o
        //limpiar las variables que se utilizan en la clase o incluso recibir datos
        public cAutomovil()
        {
            _modelo = "";
            _marca = "";
            _year = "";
            _color = "";
            _tipo = "";
            _tipoCombustible = "";
            _transmision = "";
            _es4x4 = false;
        }


        //Metodos de Get y Set

        /// <summary>
        /// Metodo de Set para asignar valor proveniente del main
        /// </summary>
        /// <param name="modelo"></param>
        public void setModelo(string modelo)
        {
            _modelo = modelo;
        }

        /// <summary>
        /// Metodo para retornar al main valores propios de la clase
        /// </summary>
        /// <returns>_modelo</returns>
        public string getModelo()
        {
            return _modelo;
        }


        public string getLLenarTanque()
        {
            return mensajeGasolina;
        }



        //Metodos = acciones que se realizan en la clase

        void metodoClase()
        {



        }

        void metodoUber()
        {


        }

        void metodoTaxi()
        {
        }


        void metodoDeportivo()
        {
        }


        void necesitaCambiaLLanta(string estadoLlanta)
        {

            //estado llanta = lisa, pinchada, desinflada, normal

            switch (estadoLlanta.ToLower())
            {

                case "lisa":
                    comprarLlanta = true;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "pinchada":
                    comprarLlanta = false;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "desinflado":
                    comprarLlanta = false;
                    cambiarLlanta(estadoLlanta.ToLower());
                    break;
                case "normal":
                    mensajeCambioLLanta = "Llanta en condiciones estables";
                    break;

                default:
                    break;
            }

        }

        void cambiarColor()
        {

            //lijar, masilla, color gris, pulir, pintar

            fasePintura = "inicio";

            while (fasePintura = !"terminado")
            {
                switch (fasePintura.ToLower())
                {
                    case "lijar":
                        cambiarColor = false;
                        cambiarColor(fasePintura.ToLower());
                        break;
                    case "Masilla":
                        cambiarColor = false;
                        cambiarColor(fasePintura.ToLower());
                        break;
                    case "Color gris":
                        cambiarColor = false;
                        cambiarColor(fasePintura.ToLower());
                        break;
                    case "Pulir":
                        mensajeCambioPintura = "Llanta en condiciones estables";
                        break;
                    case "Pintar"
                    mensajeCambioPintura = "El carro está listo para pintar"                   

                    default:
                        break;
                }
            }

        }
        void cambiarColor(string estado)
        {

            if (cambiarPintura == true && estado == "lijar")
            {
                mensajeCambioPintura = "Debe lijar el carro para poder pintarlo";
            }
            else
            {
                if (cambiarPintura == false && estado == "masilla")
                {
                    mensajeCambioPintura = "Debe ponerle masilla al carro para reparar hoyos";

                }
                else
                {
                    if (cambiarPinturaa == false && estado == "Color gris")
                    {

                        mensajeCambioLLanta = "Debe pintar el carro gris";

                    }
                }
            }


            string elegirColor()
        {

            //variables colores
            string color;
            //recibir respueste del usuario del color
            //regresar color al metodo original

            return color;

        }

        void cambiarLlanta(string estado)
        {

            if (comprarLlanta == true && estado == "lisa")
            {
                mensajeCambioLLanta = "Debe de comprar llanta e instalarla";
            }
            else
            {
                if (comprarLlanta == false && estado == "pinchada")
                {
                    mensajeCambioLLanta = "Debe de comprar reparar la llanta";

                }
                else
                {
                    if (comprarLlanta == false && estado == "desinflada")
                    {

                        mensajeCambioLLanta = "Debe de comprar inflar la llanta";

                    }
                }
            }




        }


        void llenarTanque(string nivelGasolina)
        {
            //medio tanque = tiene que llenar

            if (nivelGasolina == "medio tanque")
            {
                mensajeGasolina = "Debe de llenar el tanque";
            }
            else
            {
                mensajeGasolina = "Nivel de gasolina es suficiente, no debe de llenar";

            }

        }

        void arrancarCarro(bool motorEncendido)
        {
            if (motorEncendido == true)
            {
                mensajeEncendido = "Vehiculo encendido";
            }
            else
            {
                mensajeEncendido = "Vehiculo apagado, proceder a encenderlo";
            }
        }

    }
}
}
