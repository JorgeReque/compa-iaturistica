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
        public Lancha()
        {

        }

        public string TipoVehiculo()
        {

            return "Lancha";
        }
        public Lancha(string _matricula , string _marca,string _modelo,string _color,double _precioTrasporte
            ,string _estadoDeMovimiento,string _estadoVehiculo,string _pasajeros,string _casco)
        {
            casco = "500 metros cubicos";

            precioTransporte=70;
        }
        
    }
}
