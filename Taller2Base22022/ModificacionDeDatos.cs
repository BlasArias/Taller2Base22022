using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using MySql.Data.MySqlClient;

namespace Taller2Base22022
{
    public partial class ModificacionDeDatos : Form
    {
        public ModificacionDeDatos()
        {
            InitializeComponent();
        }

        private void ModificacionDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverModificacion_Click(object sender, EventArgs e)
        {
            Form1 volverAdmin2 = new Form1();
            volverAdmin2.Show();
            this.Hide();
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            InsertarDatos AccederInsertar = new InsertarDatos();
            AccederInsertar.Show();
            this.Hide();
        }
    }
}
