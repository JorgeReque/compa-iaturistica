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
        public Helicoptero(string _matricula, string _marca, string _modelo, string _color, double _precioTrasporte
            , string _estadoDeMovimiento, string _estadoVehiculo, string _pasajeros, string _helice)
        {
            helice ="numero de helices: "+2;
            precioTransporte=120;
    }
    }
}
