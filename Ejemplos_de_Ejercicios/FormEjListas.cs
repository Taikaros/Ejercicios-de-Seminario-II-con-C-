using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormEjListas : Form
    {
        public FormEjListas()
        {
            InitializeComponent();
        }
        List<string> listaNombres = new List<string>();
        private void FormEjListas_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            listaNombres.Add(txb_Ingresar.Text);
            dataGridView1.Rows.Add(txb_Ingresar.Text);
        }

        private void btn_VerDato_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Proximamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int rowIndex = dataGridView1.CurrentRow.Index;
            if (rowIndex >= 0 && rowIndex < listaNombres.Count)
            {
                listaNombres.RemoveAt(rowIndex);
                // Actualiza la grid si corresponde
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }

        private void btn_Ordenar_Click(object sender, EventArgs e)
        {
            listaNombres.Sort();
            dataGridView1.Rows.Clear();
            foreach (var nombre in listaNombres)
            {
                dataGridView1.Rows.Add(nombre);
            }
        }
    }
}