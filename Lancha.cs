using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compañia_turistica
{
    class Lancha:Maritimo
    {

        private string casco;

        //protected string matricula;
        //protected string marca;
        //protected string modelo;
        //protected string color;

        //protected string estadoDeMovimiento;
        //protected string estadoVehiculo = "";
        //protected string pasajeros = "";
        protected double precioTransporte;
        

        public override string TipoVehiculo
        {

            get { return "Lancha"; }
        }
        public Lancha()
        {
            matricula = "XE12";
            marca = "Daemon Yacht";
            modelo = "Hypalon";
            color = "azul";
            precioTransporte = 70;
            estadoDeMovimiento = "en espera";
            estadoVehiculo = "Apagado";
            casco = "500 metros cubicos";

            
        }
        public string MostrarInfoLancha()
        {
            return "Matricula: " + matricula + "//Marca: " + marca + "//Modelo: " + modelo + "//" +
                casco + "//Color: " + color + "//Precio de transporte: " + precioTransporte
                + "//Estado de movimiento: " + estadoDeMovimiento
                + "//Estado del vehiculo" + estadoVehiculo + "//Pasajeros" + pasajeros;
        }

    }
}
