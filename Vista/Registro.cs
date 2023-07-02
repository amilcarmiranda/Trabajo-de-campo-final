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
    class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string CE { get; set; }
        public string Grado { get; set; }
        public string Oficina { get; set; }
    }
    public partial class Registro : Form
    {
        
        public Registro()
        {
            InitializeComponent();
            
        }
        

        private void Registro_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var _inicio = new Inicio();
            this.Close();
            _inicio.Show();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string errores = "";
            var usuario = new Usuario();
            if(ContieneLetras(txtNombre.Text) == true && txtNombre.Text.Length>0)
            {
                usuario.Nombre = txtNombre.Text;
            }
            else
            {
                errores += "Error en el nombre\n";
            }
            if (ContieneLetras(txtApellido.Text) ==true && txtApellido.Text.Length > 0)
            {
                usuario.Apellido = txtApellido.Text;
            }
            else
            {
                errores += "Error en el apellido\n";
            }

            if (ContieneNumeros(txtDNI.Text) == true && (txtDNI.Text.Length >= 7 || txtDNI.Text.Length <= 10) )
            {
                usuario.DNI = txtDNI.Text;
            }
            else
            {
                errores += "Error en el DNI\n";
            }

            if (ContieneNumeros(txtCE.Text) == true && (txtCE.Text.Length <= 8))
            {
                usuario.CE = txtCE.Text;
            }
            else
            {
                errores += "Error en el Codigo estadistico\n";
            }
            if (ContieneLetras(txtOficina.Text) == true && txtOficina.Text.Length > 0)
            {
                usuario.Nombre = txtNombre.Text;
            }
            else
            {
                errores += "Error en la oficina\n";
            }
            if (txtGrado.Text.Length > 0)
            {
                usuario.Grado = txtGrado.Text;
            }
            else
            {
                errores += "Error en el grado\n";
            }

            if(errores.Length<= 1)
            {
                //LOGICA PARA GUARDAR EN BASE DE DATOS
                MessageBox.Show("Usuario creado con exito");
                
            }
            else
            {
                MessageBox.Show(errores);
            }
            
        }

        bool ContieneNumeros(string variable)
        {
            foreach (char c in variable)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        bool ContieneLetras(string variable)
        {
            foreach (char c in variable)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
