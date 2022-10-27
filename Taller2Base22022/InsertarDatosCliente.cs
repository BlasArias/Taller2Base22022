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
    public partial class InsertarDatosCliente : Form
    {
        public InsertarDatosCliente()
        {
            InitializeComponent();
        }

        private void btnVolverInsertarCliente_Click(object sender, EventArgs e)
        {
            InsertarDatos volverAdmin5 = new InsertarDatos();
            volverAdmin5.Show();
            this.Hide();
        }

        private void btnClienteInsertado_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            int saldoCliAdd = 0;
            int NumeroCli = 0;

            /*Revisar inserciones numericas*/

            if (txtInsertarRutCliente.Text != "" || txtInsertarNombreCliente.Text != "" || txtInsertarDireccionCliente.Text != "" || txtInsertarTelefCliente.Text != "")
            {
                if (ValidarLargoRut() == true)
                {
                    string query = "INSERT INTO Cliente(Rut, Nombre, Saldo, Direccion, Telefono, estado) VALUES ('" + txtInsertarRutCliente.Text + "', '" + txtInsertarNombreCliente.Text + "', '" + saldoCliAdd + "', '" + txtInsertarDireccionCliente.Text + "', '" + NumeroCli + "', 0);";
                    int insertarCliente = conex.executeNonQuery(query);

                    if (insertarCliente == 1)
                    {
                        MessageBox.Show("Cleinte Ingresado al sistema");
                        txtInsertarRutCliente.Clear();
                        txtInsertarNombreCliente.Clear();
                        txtInsertarSaldoCliente.Clear();
                        txtInsertarDireccionCliente.Clear();
                        txtInsertarTelefCliente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cleinte no a sido Ingresado al sistema");
                    }
                }
                else
                {
                    MessageBox.Show("El largo del rut debe ser de 8 a 9 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Los campos deben estar completos");
            }

            conex.close();
        }

        private bool ValidarLargoRut()
        {
            if (txtInsertarRutCliente.Text.Length >=8)
            {
                return true;
            }
            return false;
        }

        private void InsertarDatosCliente_Load(object sender, EventArgs e)
        {
            txtInsertarRutCliente.MaxLength = 9;
        }
    }
}
