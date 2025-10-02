using System;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormPilas : Form
    {
        public FormPilas()
        {
            InitializeComponent();
            Metodos.SetPlaceholder(txb_Ingresar, "Ingrese un dato: ");
        }

        private void FormPilas_Load(object sender, EventArgs e)
        {

        }
    }
}
