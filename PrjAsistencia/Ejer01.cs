using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjAsistencia
{
    public partial class Ejer01 : Form
    {
        public Ejer01()
        {
            InitializeComponent();
            Txtcod.Text = "codigo";
            Txtpass.Text = "password";
        }
        
        public static  String[,] gdocente = new string[100, 100];
        public static  int gcontdoc;
        private void Btnok_Click(object sender, EventArgs e)
        {
            for (int li = 0; li <= gcontdoc; li++)
            {
                if (gdocente[li, 0].Equals(Txtcod.Text))
                {
                    if (gdocente[li, 6].Equals(Txtpass.Text))
                    {
                       // MessageBox.Show("bienvenido");
                        //break;
                        FrmPrincipal  objFrm =new FrmPrincipal() ;
                        objFrm.Show();

                        break;
                    }
                }

            }
        }

        private void Ejer01_Load(object sender, EventArgs e)
        {
            gdocente[0, 0] = "1234567890";
            gdocente[0, 1] = "Elart";
            gdocente[0, 2] = "Rodriguez";
            gdocente[0, 3] = "pocollay S/n";
            gdocente[0, 4] = "952123456";
            gdocente[0, 5] = "docente";
            gdocente[0, 6] = "123456";
            // segund docente
            gdocente[1, 0] = "1234567891";
            gdocente[1, 1] = "Minely";
            gdocente[1, 2] = "Marinez";
            gdocente[1, 3] = "Cercado S/n";
            gdocente[1, 4] = "952818776";
            gdocente[1, 5] = "docente";
            gdocente[1, 6] = "luis12";
            // tercero docente
            gdocente[2, 0] = "1234567892";
            gdocente[2, 1] = "Hayde";
            gdocente[2, 2] = "sisa";
            gdocente[2, 3] = "cono sur S/n";
            gdocente[2, 4] = "945988181";
            gdocente[2, 5] = "docente";
            gdocente[2, 6] = "luis13";
            //cuarto docente 
            gdocente[3, 0] = "1234567893";
            gdocente[3, 1] = "Marcia";
            gdocente[3, 2] = "Martinez";
            gdocente[3, 3] = "Alto lima S/n";
            gdocente[3, 4] = "988888888";
            gdocente[3, 5] = "docente";                     
            gdocente[3, 6] = "luis14";
            // quinto docente
            gdocente[4, 0] = "1234567894";
            gdocente[4, 1] = "Daniel";
            gdocente[4, 2] = "Soto";
            gdocente[4, 3] = "pocollay S/n";
            gdocente[4, 4] = "454842";
            gdocente[4, 5] = "Docente";
            gdocente[4, 6] = "luis15";
        gcontdoc =4;
        }

        

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Application .Exit ();
        }
    }
}
