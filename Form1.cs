﻿using System;
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
        public bool NewInstance(string instance)
        {
            if ("carro" == instance)
            {
                obj = new Carro();
                return true;
            }
            return false;
        }

        //crear un boton para llamar al metodo 
        public string crearInstancia()
        {
            string tipoVehiculo;
            if (rbCarro.Checked) { }
            if (NewInstance(tipoVehiculo))
            {
                return "se creo";
            }
            return "no se creo";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            string Resultado;

            Resultado = crearInstancia();
           

            richTexResultado.Text = Resultado;

        }
    }

    
    
}
