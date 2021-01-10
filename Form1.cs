using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compañia_turistica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        Vehiculo obj;
        public bool NewInstance(string obCrear)
        {
            if ("carro" == obCrear)
            {
                obj = new Carro();
                return true;
            }else if("helicoptero" == obCrear)
            {
                obj = new Helicoptero();
                return true;
            }else if("Lancha" == obCrear)
            {
                obj = new Lancha();
                return true;
            }
            return false;
        }

        //crear un boton para llamar al metodo 
        public string crearInstancia()
        {
            string tipoVehiculo="";
            if (rbCarro.Checked) { 
                tipoVehiculo="carro";
            }
            if (rbHelicoptero.Checked) {//para el check de helicoptero
                tipoVehiculo="helicoptero";
            }
            if (rbLancha.Checked) {//para el check de lacha 
                tipoVehiculo="Lancha";
            }

            if( tipoVehiculo == ""){// si no selecciona una opcion
                return "NO SE ELIGIO NINGUNA OPCION";
            }

            if (NewInstance(tipoVehiculo))
            {
                return "RESERVA EXITOSA  DE VEHICULO: "+obj.TipoVehiculo();
            }
            return "NO SE CREO LA RESERVA ";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = crearInstancia();
            richTexResultado.Text = Resultado;
        }
    }
    
}
