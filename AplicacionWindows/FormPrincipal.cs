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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "")
            {
                txtDatos.Text = "Apellido y Nombre: " + txtApellido.Text.ToLower() + " " + txtNombre.Text.ToLower() +
                                    "\r\n Edad: " + txtEdad.Text.ToLower() +
                                    "\r\n Direccion: " + txtDireccion.Text.ToLower();
            }

            else
            {
                txtNombre.BackColor = Color.Red;
                txtEdad.BackColor = Color.Red;
                txtDireccion.BackColor = Color.Red;
                txtApellido.BackColor = Color.Red;
            }
        }





        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar>=48 && e.KeyChar<=57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            
           
                txtApellido.BackColor = Color.White;
            
          
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.BackColor = Color.White;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.BackColor = Color.White;
        }
        private void FormEjercicioTp1_Click(object sender, EventArgs e)
        {
            FormEjercicioTp1 formEjercicioTp1 = new FormEjercicioTp1(this);
            formEjercicioTp1.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 formEjercicio2 = new FormEjercicio2(this);
            formEjercicio2.Show();
            this.Hide();
        }




        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 formEjercicio3 = new FormEjercicio3(this);
            formEjercicio3.Show();
            this.Hide();

        
        }
        


        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculadora formCalculadora = new FormCalculadora(this);
            formCalculadora.Show();
            this.Hide();

        }


        private void btnPractica6_Click(object sender, EventArgs e)
        {
            FormPractica6 formPractica6 = new FormPractica6(this);
            formPractica6.Show();
            this.Hide();

        }

        private void btnPractica8_Click(object sender, EventArgs e)
        {
            FormPractica8 formPractica8 = new FormPractica8(this);
            formPractica8.Show();
            this.Hide();
        }
    }
}
