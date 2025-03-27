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
    public partial class FormPractica6 : Form
    {
        FormPrincipal formPrincipal;
        public FormPractica6(FormPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(txtIngresoNombre.Text!= "")
            {
                string Programador = checkBoxProgramador.Checked ? "Programador" : "No Programador";
                string genero = rdbHombre.Checked ? "Hombre" : "Mujer";
                txtSalida.Text = txtIngresoNombre.Text + "\r\n" + Programador + "\r\n" + genero;
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre", "Atencion");
            }
        }

        private void FormPractica6_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
            
        }

        private void FormPractica6_Load(object sender, EventArgs e)
        {

        }

        private void txtIngresoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) ||  // Letras mayúsculas (A-Z)
               (e.KeyChar >= 97 && e.KeyChar <= 122) || // Letras minúsculas (a-z)
               (e.KeyChar == 8))  // Backspace (para borrar)
            {
                e.Handled = false; // Permite el ingreso
            }
            else
            {
                e.Handled = true; // Bloquea cualquier otra tecla
            }
        }
    }
}

