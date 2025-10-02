using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormEjPilas : Form
    {
        public FormEjPilas()
        {
            InitializeComponent();
            Metodos.SetPlaceholder(txb_Ingresar, "Ingrese un Dato");
        }

        private void FormEjPilas_Load(object sender, EventArgs e)
        {

        }
        Stack<string> Pila = new Stack<string>();
        private void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Pila)
            {
                dataGridView1.Rows.Add(item);
            }
        }
        private void PeekPila()
        {
            try
            {
                if (Pila.Count != 0)
                {
                    MessageBox.Show($"El ultimo elemento de la cola es: " + Pila.LastOrDefault(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (Pila.Count != 0)
                {
                    Pila.Pop();
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
                Pila.Push(elemento);
                dataGridView1.Rows.Add(elemento);
                refreshDataGridView();
                MessageBox.Show("Elemento agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_agregar_Click_1(object sender, EventArgs e)
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

        private void btn_Recuperar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Las Pilas no permiten recuperar elementos eliminados, solo se puede ver el primer elemento o eliminarlo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
