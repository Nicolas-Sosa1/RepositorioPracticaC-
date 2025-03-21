using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows
{
    public partial class FormEjercicio3 : Form
    {

        FormPrincipal formPrincipal;
        public FormEjercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

      

        private void FormEjercicio3_Load(object sender, EventArgs e)
        {



        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string genero = rdbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rdbSoltero.Checked ? "Soltero" : "Casado";

            lblResultados.Text = "Usted seleccionó los siguientes elementos:\n" +
            "Sexo: " + genero + "\n" +
            "Estado Civil: " + estadoCivil + "\n" +
            "Oficio:\n";

            foreach(string item in clbOficio.CheckedItems)
            {
                lblResultados.Text += item + "\n";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }
    }
}
