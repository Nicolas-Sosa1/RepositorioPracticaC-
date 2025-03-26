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
            else if(txtApellido.Text == "" && txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre y apellido", "Atención");
            }
            else if(txtApellido.Text != "" && txtNombre.Text == ""){

                MessageBox.Show("Debe ingresar un nombre", "Atención");
            }
            else
            {
                MessageBox.Show("Debe ingresar un apellido", "Atención");
            }
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {

            //if (lbRecibeElementos.SelectedItems.Count>0)
            //{
            //    List<string> itemSeleccionados = new List<string>();

            //    foreach(string item in lbRecibeElementos.SelectedItems)
            //    {
            //        itemSeleccionados.Add(item);
            //    }

            //    foreach(string item in itemSeleccionados)
            //    {
            //        lbRecibeElementos.Items.Remove(item);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Debe selecionar al menos Elemento", "Atencion");
            //}


            if (lbRecibeElementos.SelectedItems.Count > 0)
            {
                // Crear un array con los elementos seleccionados
                string[] itemSeleccionados = new string[lbRecibeElementos.SelectedItems.Count];

                for (int i = 0; i < lbRecibeElementos.SelectedItems.Count; i++)
                {
                    itemSeleccionados[i] = lbRecibeElementos.SelectedItems[i].ToString(); // CORREGIDO
                }

                // Eliminar los elementos seleccionados
                foreach (string item in itemSeleccionados)
                {
                    lbRecibeElementos.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un elemento", "Atención");
            }





        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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
