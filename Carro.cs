using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compañia_turistica
{
    class Carro : Terrestre
    {

        private string llanta;
        protected double precioTransporte;


        
        
        public override string TipoVehiculo
        {

           get { return "Carro"; }
        }
        public Carro()
        {
            matricula = "XG11";
            marca = "Mercedes benz";
            modelo = "Jeep Renegade";
            llanta = "numero de llantas: " + 4;
            color = "Rojo";
            precioTransporte=50;
            estadoDeMovimiento = "en espera";
            estadoVehiculo = "apagado";
             
    }
        public string MostrarInfoCoche()
        {
            return "Matricula: " + matricula + "//Marca: " + marca + "//Modelo: " + modelo +"//"+
                llanta+"//Color: " + color+"Precio de transporte: "+precioTransporte
                + "//Estado de movimiento: " + estadoDeMovimiento
                + "//Estado del vehiculo" + estadoVehiculo + "//Pasajeros" + pasajeros;
        }
    }
}
