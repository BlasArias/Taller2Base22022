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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarClave clave = new IngresarClave("Ingresar Clave");
            clave.Show();
            this.Hide();
        }

        private void btnAccederConsultarDatos_Click(object sender, EventArgs e)
        {
            ConsultaDatos AccederConsulta = new ConsultaDatos();
            AccederConsulta.Show();
            this.Hide();
        }
    }
}
