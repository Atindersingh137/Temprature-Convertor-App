using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp
{
    public partial class Form1 : Form
    {

        //instance of a class
        conversion myconversion = new conversion();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFahToCel_Click(object sender, EventArgs e)
        {
            txtCel.Text = myconversion.FahToCel(txtFah.Text);
        }

        private void btnCelToFah_Click(object sender, EventArgs e)
        {
            txtFah.Text = myconversion.CelToFah(txtCel.Text);
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFah_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
