using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormEjColas : Form
    {
        public FormEjColas()
        {
            InitializeComponent();
            Metodos.SetPlaceholder(txb_Ingresar, "Ingrese un número");
        }

        private void FormEjColas_Load(object sender, EventArgs e)
        {

        }
        Queue<string> Cola = new Queue<string>();
        private void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Cola)
            {
                dataGridView1.Rows.Add(item);
            }
        }
        private void PeekPila()
        {
            try
            {
                if (Cola.Count != 0)
                {
                    MessageBox.Show($"El ultimo elemento de la cola es: " + Cola.LastOrDefault(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Eliminar()
        {
            try
            {
                if (Cola.Count != 0)
                {
                    Cola.Dequeue();
                    refreshDataGridView();
                    MessageBox.Show("Elemento eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La cola está vacía", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarPila(string elemento)
        {
            try
            {
                Cola.Enqueue(elemento);
                dataGridView1.Rows.Add(elemento);
                refreshDataGridView();
                MessageBox.Show("Elemento agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarPila(txb_Ingresar.Text);
        }

        private void btn_VerDato_Click(object sender, EventArgs e)
        {
            PeekPila();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btn_Recuperar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Las Pilas no permiten recuperar elementos eliminados, solo se puede ver el primer elemento o eliminarlo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}