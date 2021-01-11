using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compañia_turistica
{
    class Helicoptero:Aereo
    {

        private string helice;
        protected double precioTransporte;

   
        public override string TipoVehiculo
        {

            get { return "Helicoptero"; }
        }
        public Helicoptero()
        {
            matricula = "XF10";
            marca = "Agusta Westland AW109 Grand Versace";
            modelo = "Helicoptero de transporte";
            color = "verde";
            precioTransporte = 120;
            estadoDeMovimiento = "en espera";
            estadoVehiculo = "Apagado";
            helice ="numero de helices: "+2;
           
        }

        public string MostrarInfoHelicoptero()
        {
            return "Matricula: " + matricula + "//Marca: " + marca + "//Modelo: " + modelo + "//" +
                helice + "//Color: " + color + "//Precio de transporte: " + precioTransporte
                + "//Estado de movimiento: " + estadoDeMovimiento
                + "//Estado del vehiculo" + estadoVehiculo + "//Pasajeros" + pasajeros;
        }
    }
}
