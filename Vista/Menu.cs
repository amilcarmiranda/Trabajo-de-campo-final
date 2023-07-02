using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_de_campo_final.Vista
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            string[,] menu = new string[10, 10];
            menu[0, 0] = "Uniformados"; // x,0  es el nombre de arriba
            menu[0, 1] = "Alta"; // x,y es el submenu
            menu[0, 2] = "Baja";
            menu[0, 3] = "Modificacion";
            menu[0, 4] = "Consulta";
            menu[1, 0] = "Horas Trabajadas";
            menu[1, 1] = "Registrar";
            menu[1, 2] = "Consultar";
            menu[2, 0] = "Rol de Combate";
            menu[2, 1] = "Asignar";
            menu[2, 2] = "Consultar";//de la misma forma completa los que restan

            var consult = menuStrip1.Items.IndexOfKey("Consulta");

            for (int i = 0; i <= 9; i++)
            {
                //if(i != null)
                //{
                ToolStripMenuItem menufly = new ToolStripMenuItem();
                for (int j = 0; j <= 9; j++)
                {
                    if (menu[i, j] != null)
                    {
                        
                        if (j == 0)
                        {
                            var menufli = new ToolStripMenuItem(menu[i, j]);
                            menufly = menufly;
                            
                        }
                        else
                        {
                            ToolStripMenuItem submenuflyitem = new ToolStripMenuItem(menu[i, j]);
                            menufly.DropDownItems.Add(submenuflyitem);
                        }
                        


                    }
                }
                menufly.Text = menu[i, j];
                menuStrip1.Items.Add(menufly);
                //}

            }


            
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
