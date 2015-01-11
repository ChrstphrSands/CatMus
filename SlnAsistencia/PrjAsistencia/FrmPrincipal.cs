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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        
        public static int gcontal;
        public static int gconcur;
        public static int gconasis;
        public static int gcontaluasis;
        public static string[,] galumno = new string[500, 500];
        public static string[,] gcurso = new string[500, 500];
        public static string[,] gasistencia = new string[500, 500];
        public static string[,] gasisalu = new string[500, 500];

        private void comboBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Pnldocente.Visible = false;
            Pnlalu.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pnldocente.Visible = true;
            Grpdocente.Enabled = false;
            Btnguardar.Enabled = false;
            Btnlimpiar.Enabled = false;
            Btnmodificar.Enabled = false;
            Btnnuevo.Focus();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Txtapellido.Text = "";
            Txtcodigo.Text = "";
            Txtdireccion. Text = "";
            Txtnombre.Text = "";
            Txtnumero.Text = "";
            Txtpass.Text = "";
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
            Grpdocente.Enabled = true;
            Cmbcargo.Items.Add("docente");
            Cmbcargo.Items.Add("director");
            Cmbcargo.Items.Add("Contratado");
            Cmbcargo.Items.Add("Tutor");
            Cmbcargo.Items.Add("Tiempor Completo");
            Txtcodigo.Focus();
            Btnguardar.Enabled = true;
            Btnlimpiar.Enabled = true;
            Btnmodificar.Enabled = true;
            /////
            Btnnuevo.Enabled = false;
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
           /////
            Ejer01.gcontdoc++;
            MessageBox.Show(Convert.ToString(Ejer01.gcontdoc));
            Ejer01.gdocente[Ejer01.gcontdoc, 0] = Txtcodigo.Text;
            Ejer01.gdocente[Ejer01.gcontdoc, 1] = Txtnombre.Text;
            Ejer01.gdocente[Ejer01.gcontdoc, 2] = Txtapellido.Text;
            Ejer01.gdocente[Ejer01.gcontdoc, 3] = Txtdireccion.Text;
            Ejer01.gdocente[Ejer01.gcontdoc, 4] = Txtnumero.Text;
            Ejer01.gdocente[Ejer01.gcontdoc, 5] = Cmbcargo.SelectedItem.ToString ();
            Ejer01.gdocente[Ejer01.gcontdoc, 6] = Txtpass .Text ;
            Btnnuevo.Enabled = true;
            Grpdocente.Enabled = false;

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pnlalu.Visible = true;
            Grpalumno.Enabled = false;
            Btnguardaralu .Enabled = false;
            Btnlimpiaralu.Enabled = false;
            Btnmodificaralu.Enabled = false;
            Btnnuevoalu.Focus();
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            string layudame = Txtbuscar.Text; int lvalor=0;
            for (int li = 0; li <= Ejer01.gcontdoc; li++)
            {// sim deseo agregar el operador or y el 
                if (layudame.Equals(Ejer01.gdocente[li, 0]) ) // layudame.Equals(Ejer01.gdocente[li, 2])\\  )
                {
                   lvalor = 1;
                   Txtcodigo.Text = Ejer01.gdocente[li, 1];
                      Txtnombre .Text   = Ejer01.gdocente[li, 2];
                      Txtapellido.Text = Ejer01.gdocente[li, 3];
                    Txtdireccion .Text =Ejer01 .gdocente[li,3];
                    Txtnumero.Text = Ejer01.gdocente[li, 4];
                    Txtpass.Text = Ejer01.gdocente[li, 6];
                    Cmbcargo.SelectedText = Ejer01.gdocente[li, 5];
                    break;
                }
            }
            if (lvalor == 0)
            {
                MessageBox.Show("no  hay  nadie");
            }
        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            for (int li = 0; li <= Ejer01.gcontdoc; li++)
            {
                if (Txtcodigo.Text.Equals(Ejer01.gdocente[li, 0]))
                {
                    Ejer01.gdocente[li,1] = Txtnombre.Text ;
                    Ejer01.gdocente[li,2] = Txtapellido.Text;
                    Ejer01.gdocente[li,3] = Txtdireccion.Text;
                    Ejer01.gdocente[li,4] = Txtnumero.Text;
                    Ejer01.gdocente[li,5] = Cmbcargo.SelectedItem.ToString(); 
                    Ejer01.gdocente[li,6] = Txtpass .Text ;

                }
            }
        }

        private void Btnnuevoalu_Click(object sender, EventArgs e)
        {
            Grpalumno.Enabled = true;
            MtdLlenarCbocurso();
            Btnguardaralu.Enabled = true;
            Btnlimpiaralu.Enabled = true;
            //Cbocurso.Items.Add("docente");
            //Cbocurso.Items.Add("director");
            //Cbocurso.Items.Add("Contratado");
           // Cbocurso.Items.Add("Tutor");
            //Cbocurso.Items.Add("Tiempor Completo");
            //Txtcodalu.Focus();
        }

        private void MtdLlenarCbocurso()
        {
            Cbocurso.Items.Add("SI-161");
        }

        private void Btnlimpiaralu_Click(object sender, EventArgs e)
        {
            MtdLimpiarcajaalu();
            MtdLimpiarcurso();
        }

        private void MtdLimpiarcurso()
        {
            Lstalumno .Items .Clear ();
            Lstcurso.Items.Clear();
        }

        private void MtdLimpiarcajaalu()
        {
            Txtnomalu.Text = "";
        }

        private void Btnguardaralu_Click(object sender, EventArgs e)
        {
            galumno[gcontal, 0] = Txtcodalu.Text;
            galumno[gcontal, 1] = Txtnomalu.Text;
            galumno[gcontal, 2] = Txtmailalu.Text;
            gcontal++;
            Lstalumno.Items.Add(Txtnomalu.Text);
        }

        private void Cbocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbocurso.SelectedItem.ToString().Equals("SI-161"))
            {
                Txtcodcurso.Text = "Calculo I";
            }
        }

        private void Btnguardarcurso_Click(object sender, EventArgs e)
        {
            gconcur++;
            gcurso[gconcur, 0] = Cbocurso.SelectedItem.ToString();
            gcurso[gconcur, 1] = Txtcodcurso.Text;
            gcurso[gconcur, 2] = Txtcodalu.Text;
            gcurso[gconcur, 3] = Txtnomalu.Text;

            Lstcurso.Items.Add(Txtcodcurso.Text);
        }

        private void Buscarasis_Click(object sender, EventArgs e)
        {
            for (int li = 0; li <= gconcur; li++)
            {
                if (Txtbuscarasis.Text.Equals(gcurso[li,0]))
                {
                    Lstaluasis.Items.Add(gcurso[li, 3]);
                }
            }
        }

        private void Btnguardarasis_Click(object sender, EventArgs e)
        {
            // Contador alumnos que se ha tomado asistencia
            int layuda = Lstaluasis.Items.Count;

            gconasis++;
            gasistencia[gconasis, 0] = DtpFecha.Text;
            gasistencia[gconasis, 1] = Txtcodcurso.Text;

            for (int li = 0; li <= layuda; li++)
            {
                gasisalu[gconasis, 0] = Lstaluasis.Items[li].ToString();
                if (Rdbpresente.Checked == true)
                {
                    gasisalu[gconasis, 1] = "Presente"; 
                }
                if (Rdbtarde.Checked == true)
                {
                    gasisalu[gconasis, 1] = "Tarde";
                }
                if (Rdbausente.Checked == true)
                {
                    gasisalu[gconasis, 1] = "Ausente";
                }
            }


        }
    }
}
