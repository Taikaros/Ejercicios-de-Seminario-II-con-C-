using System.Diagnostics;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public partial class Aplicacion_Central : Form
    {
        public Aplicacion_Central()
        {
            InitializeComponent();
            CustomDesign();
        }
        private Form activeForm = null;
        private FormListas formListas;
        private FormPilas formPilas;
        private FormColas formColas;
        private void CustomDesign()
        {
            /// <summary>
            /// Metodo para personalizar el diseño del menu
            /// </summary>

            //Codigo para ocultar los submenus
            panelSubmenuEjercicios.Visible = false;
            panelSubmenuEjemplos.Visible = false;
            panelSubmenuAyuda.Visible = false;
            //Codigo para personalizar
        }
        #region botones de Menu
        private void btn_Ejercicios_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.ShowSubMenu(panelSubmenuEjercicios, panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);

        }

        private void btn_Ejemplos_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.ShowSubMenu(panelSubmenuEjemplos, panelSubmenuEjercicios, panelSubmenuEjercicios, panelSubmenuAyuda);
        }

        private void btn_Ayuda_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.ShowSubMenu(panelSubmenuAyuda, panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuEjercicios);

        }

        private void btn_Salida_Click(object sender, System.EventArgs e)
        {
            Metodos.NotificacionSound();
            // Condición para mostrar una ventana de confirmación antes de salir de la aplicación
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
            if (MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_Listas_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            if (formListas == null || formListas.IsDisposed)
                formListas = new FormListas();
            Metodos.openPanelChildForm(formListas, panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_Pila_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            if (formPilas == null || formPilas.IsDisposed)
                formPilas = new FormPilas();
            Metodos.openPanelChildForm(formPilas, panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_Cola_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            if (formColas == null || formColas.IsDisposed)
                formColas = new FormColas();
            Metodos.openPanelChildForm(formColas, panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }
        #endregion Botones de ejercicios
        #region botones de ejemplos
        private void btn_EjLista_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.openPanelChildForm(new FormEjListas(), panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_EjCola_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.openPanelChildForm(new FormEjColas(), panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_EjPila_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.openPanelChildForm(new FormEjPilas(), panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_EjDictionary_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            Metodos.openPanelChildForm(new FormEjDictionary(), panelChildForms, ref activeForm);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }
        #endregion Botones de ejemplos
        #region botones de ayuda
        private void btn_Repositorio_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            string url = "www.google.com.ar";
            Process.Start(url);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_Help_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            string url = "https://docs.google.com/presentation/d/1ovQafJAdOlzaLYvgmhH8xWwXasgMfOoGkHQF8ztzte4/edit?usp=sharing";
            Process.Start(url);
            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }

        private void btn_Readme_Click(object sender, System.EventArgs e)
        {
            Metodos.ClickSound();
            if (MessageBox.Show("¿Desea abrir el archivo README.txt?", "Abrir README", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string urld = "README.txt";
                Process.Start("notepad.exe", urld);
            }
            else if (MessageBox.Show("¿Desea abrir el archivo README.pdf?", "Abrir README", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string pdf = "README.pdf";
                Process.Start("AcroRd32.exe", pdf);
            }

            Metodos.HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
        }
        #endregion Botones de ayuda
        private void panelChildForms_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Aplicacion_Central_Load(object sender, System.EventArgs e)
        {

        }
    }
}