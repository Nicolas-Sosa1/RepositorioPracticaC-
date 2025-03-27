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
    

    public partial class FormPractica8 : Form
    {
        FormPrincipal formPrincipal;
        public FormPractica8(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormPractica8_Load(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (clbNumeros.CheckedItems.Count > 0)
            {
                foreach(string item in clbNumeros.CheckedItems)
                {
                    lbRecibidos.Items.Add(item.ToString());
                }

                for(int i = 0; i < clbNumeros.Items.Count; i++)
                {
                    clbNumeros.SetItemChecked(i, false);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar minimo uno", "Atención");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPractica8_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }
    }
}
