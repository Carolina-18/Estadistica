using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcialprogra
{
    public partial class Form1 : Form
    {
        conversores objconversor = new conversores();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = objconversor.convertir(cbotipo.SelectedIndex, cbode.SelectedIndex,
                cboa.SelectedIndex, double.Parse(txtcantidad.Text)).ToString();
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbode.Items.Clear();
            cboa.Items.Clear();
            cbode.Items.AddRange(objconversor.conversor[cbotipo.SelectedIndex]);
            cboa.Items.AddRange(objconversor.conversor[cbotipo.SelectedIndex]);

        }
    }
}
