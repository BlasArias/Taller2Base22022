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
    public partial class ConsultaDatos : Form
    {
        public ConsultaDatos()
        {
            InitializeComponent();
        }

        private void btnVolverConsultaDatos_Click(object sender, EventArgs e)
        {
            Form1 volverAdmin4 = new Form1();
            volverAdmin4.Show();
            this.Hide();
        }
    }
}
