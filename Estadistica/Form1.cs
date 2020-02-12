using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{                      //clase : herencia
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();

        //constructor
        public Form1()

        {
            InitializeComponent();
        }

        private void btnmediaaritmetica_Click(object sender, EventArgs e)
        {
            //dividi una cadena en base a un delimitador y devuelve una matriz con sus elementos
            lblrespuesta_serie.Text = "x=" + objEstadistica.media(txtserie.Text.Split(','));
        }
    }
}
