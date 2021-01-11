using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compañia_turistica
{
    class Vehiculo
    {
           protected string matricula;
           protected string marca;
           protected string modelo;
           protected string color;
           
           protected string estadoDeMovimiento;
           protected string estadoVehiculo="";
           protected string pasajeros = "Ninguno";

       

        public void TransportarPasajeros(string _pasajeros)
        {
            pasajeros = _pasajeros;
        }

        public void Encender()
        {
            estadoVehiculo = "Vehiculo encendido";
            Console.WriteLine(estadoVehiculo);
        }
        public void Apagar()
        {
            estadoVehiculo = "Vehiculo apagado";
            Console.WriteLine(estadoVehiculo);
        }
        public void Avanzar()
        {
            estadoDeMovimiento = "Vehiculo en movimiento";
            Console.WriteLine(estadoDeMovimiento);
        }
        public void Frenar()
        {
            estadoDeMovimiento = "Vehiculo detenido";
            Console.WriteLine(estadoDeMovimiento);
        }




        public virtual string TipoVehiculo { get;}
        


    }
}
