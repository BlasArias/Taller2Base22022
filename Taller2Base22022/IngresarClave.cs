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
    public partial class IngresarClave : Form
    {
        private string metodo;
        public IngresarClave(string metodo)
        {
            InitializeComponent();
            this.metodo = metodo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClaveIngresada_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "SELECT Clave FROM Contraseña;";
            string clave = conex.selectQueryScalar(query);

            if(txtIngresarClave.Text == "")
            {
                MessageBox.Show("Debe ingresar clave para entrar al sistema.");
            }
            if (txtIngresarClave.Text != clave)
            {
                MessageBox.Show("La clave ingresada no coincide.");
            }
            if (txtIngresarClave.Text == clave)
            {
                if (this.metodo == "Ingresar Clave")
                {
                    ModificacionDeDatos admin = new ModificacionDeDatos();
                    admin.Show();
                    this.Hide();
                }
            }
            conex.close();
        }

        private void btnVolverIngresoClave_Click(object sender, EventArgs e)
        {
            Form1 volverMenu = new Form1();
            volverMenu.Show();
            this.Hide();
            
            
        }
    }
}
