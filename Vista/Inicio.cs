using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_de_campo_final.Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btnVistaTest_Click(object sender, EventArgs e)
        {
            var vistatext = new Vista.test();
            vistatext.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var registro = new Registro();
            registro.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var test = new test();
            test.ShowDialog();
        }
    }
}
