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

        }

        private void FormPractica6_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
            
        }

       
    }
}

