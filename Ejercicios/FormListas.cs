using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class FormListas : Form
    {
        public FormListas()
        {
            InitializeComponent();
            Metodos.SetPlaceholder(txb_Ingresar, "Ingrese un dato: ");
        }
        private void FormListas_Load(object sender, System.EventArgs e)
        {


        }


        private void txb_Ingresar_TextChanged(object sender, System.EventArgs e)
        {
        }
    }
}
