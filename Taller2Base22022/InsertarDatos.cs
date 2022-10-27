using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2Base22022
{
    public partial class InsertarDatos : Form
    {
        public InsertarDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverInsertarDatos_Click(object sender, EventArgs e)
        {
            ModificacionDeDatos volverAdmin3 = new ModificacionDeDatos();
            volverAdmin3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarDatosCliente_Click(object sender, EventArgs e)
        {
            InsertarDatosCliente AccederInserCli = new InsertarDatosCliente();
            AccederInserCli.Show();
            this.Hide();
        }

        private void btnInsertarDatosProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarDatosProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarDatosVendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarDatosCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
