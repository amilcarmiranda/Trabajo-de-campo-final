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
            txtContrasena.UseSystemPasswordChar = true;
        }
        private void btnVistaTest_Click(object sender, EventArgs e)
        {
            var vistatext = new Vista.test();
            vistatext.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            var registro = new Registro();
            this.Hide();
            registro.Show();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "amilcar" && txtContrasena.Text == "123456")
            {
                var menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
           


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
