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
    public partial class FormEjercicio2 : Form
    {

        FormPrincipal formPrincipal;
        public FormEjercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEjercicio2_Load(object sender, EventArgs e)
        {

        }

        private void FormEjercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text != "" && txtNombre.Text != "")
            {
                string nuevoItem = txtNombre.Text.ToLower() + " " + txtApellido.Text.ToLower();

                bool existe = false;

                foreach (string item in lbRecibeElementos.Items)
                {
                    if (item.ToLower() == nuevoItem)
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe==false)
                {
                    lbRecibeElementos.Items.Add(nuevoItem);

                    // Crear y llenar un array con los elementos del ListBox
                    string[] itemsOrdenados = new string[lbRecibeElementos.Items.Count];

                    for (int i = 0; i < lbRecibeElementos.Items.Count; i++)
                    {
                        itemsOrdenados[i] = lbRecibeElementos.Items[i].ToString();
                    }

                    // Ordenar el array alfabéticamente
                    Array.Sort(itemsOrdenados);

                    // Limpiar y volver a agregar los elementos ordenados en el ListBox
                    lbRecibeElementos.Items.Clear();

                    foreach (string item in itemsOrdenados)
                    {
                        lbRecibeElementos.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Ya se ingresó ese nombre y apellido", "Atención");
                }

                txtNombre.Clear();
                txtApellido.Clear();
            }
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbRecibeElementos.SelectedItem != null)
            {
                lbRecibeElementos.Items.RemoveAt(lbRecibeElementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe selecionar un Elemento", "Atencion");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        
    }
}
