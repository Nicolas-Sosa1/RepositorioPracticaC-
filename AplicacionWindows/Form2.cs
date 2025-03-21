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
    public partial class FormEjercicioTp1 : Form
    {
        FormPrincipal formPrincipal;
        public FormEjercicioTp1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            btnAgregar.Enabled = false;

        }

        private void FormEjercicioTp1_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverPrincipal_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIngresarNombre.Text != "")
            {
                string nuevoItem = txtIngresarNombre.Text.ToLower();
                bool nombreExiste = false;
                

                foreach (string item in lbNombresAgregados.Items)
                {
                    if (item.ToLower() == nuevoItem)
                    {
                        nombreExiste = true;
                        break;
                    }
                }

                if (nombreExiste == false)
                {
                    lbNombresAgregados.Items.Add(nuevoItem.ToString());
                }
                else
                {
                    MessageBox.Show("El nombre que agregó ya está en el ListBox", "Atención");
                }

                    // LIMPIA EL TEXTBOX DESPUÉS DE PROCESARLO
                    txtIngresarNombre.Clear();
            }
        }


        private void FormEjercicioTp1_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void btnPasarNombre_Click(object sender, EventArgs e)
        {
            if (lbNombresAgregados.SelectedItem != null)
            {
                lbNombresRecibidos.Items.Add(lbNombresAgregados.SelectedItem);
                lbNombresAgregados.Items.RemoveAt(lbNombresAgregados.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe selecionar un Item");
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if (lbNombresAgregados.Items.Count > 0)
            {
                foreach (string item in lbNombresAgregados.Items)
                {
                    lbNombresRecibidos.Items.Add(item.ToString());

                }
                lbNombresAgregados.Items.Clear();
            }
        }

        private void txtIngresarNombre_KeyDown(object sender, KeyEventArgs e)
        {
            // Habilitar el botón si el TextBox no está vacío
            btnAgregar.Enabled = txtIngresarNombre.Text.Length > 0;

            // Si se presiona Enter y el TextBox no está vacío, ejecutar el click del botón
            if (e.KeyCode == Keys.Enter && btnAgregar.Enabled)
            {
                btnAgregar.PerformClick();
            }
        }

        //BOTON PASAR UNO SOLO/SELECCION
        private void btnPasarVarios_Click(object sender, EventArgs e)
        {
            //se verifica que haya seleccionado por lo menos un item
            if (lbNombresAgregados.SelectedItems.Count > 0)
            {
                //se crea un array del tamaño de los elementos selecionados
                string[] iteamsSeleccionados = new string[lbNombresAgregados.SelectedItems.Count];

                //se llena el array con el elemento seleccionado en cada posicion
                for (int i = 0; i < lbNombresAgregados.SelectedItems.Count; i++)
                {
                    iteamsSeleccionados[i] = lbNombresAgregados.SelectedItems[i].ToString();
                }

                //se mueven los elementos a lbPasados y se eliminan de lbAgregados
                foreach (var item in iteamsSeleccionados)
                {
                    lbNombresRecibidos.Items.Add(item);
                    lbNombresAgregados.Items.Remove(item);
                }
            }

            else
            {
                MessageBox.Show("Por favor seleccione al menos un item", "Atencion");
            }
        }
    }
}