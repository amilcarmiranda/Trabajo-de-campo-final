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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void btnDevolverPersona_Click(object sender, EventArgs e)
        {
            var oPersona = Controladora.PersonaController.devolverPersona();
            string cartel = "Tu nombre es \n" + oPersona.nombre  + "Tu Apellido es:" + oPersona.apellido;
            MessageBox.Show(cartel);
        }
    }
}
