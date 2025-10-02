using System;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormColas : Form
    {
        public FormColas()
        {
            InitializeComponent();
            Metodos.SetPlaceholder(txb_Ingresar, "Ingrese un dato: ");
        }

        private void FormColas_Load(object sender, EventArgs e)
        {

        }
    }
}
