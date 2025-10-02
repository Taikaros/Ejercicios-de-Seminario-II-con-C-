using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Ejercicio_de_Seminario
{
    public static class Metodos
    {
        #region Metodos Sonido
        public static void NotificacionSound()
        {
            SoundPlayer notificacion = new SoundPlayer();
            string path_Notificacion = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Media\Sonido\Notificacion.wav");
            notificacion.SoundLocation = path_Notificacion;
            notificacion.Play();
        }
        public static void ClickSound()
        {
            SoundPlayer Click = new SoundPlayer();
            string path_Click = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Media\Sonido\Click.wav");
            Click.SoundLocation = path_Click;
            Click.Play();
        }
        #endregion Metodos Sonido
        #region Metodos de diseño de menu
        public static void HideSubMenu(Panel panelSubmenuEjercicios, Panel panelSubmenuEjemplos, Panel panelSubmenuAyuda)
        {
            /// <summary>
            /// Metodo para ocultar los submenus
            /// <!----> </summary>
            if (panelSubmenuEjercicios.Visible == true)
                panelSubmenuEjercicios.Visible = false;
            if (panelSubmenuEjemplos.Visible == true)
                panelSubmenuEjemplos.Visible = false;
            if (panelSubmenuAyuda.Visible == true)
                panelSubmenuAyuda.Visible = false;
        }
        public static void ShowSubMenu(Panel subMenu, Panel panelSubmenuEjercicios, Panel panelSubmenuEjemplos, Panel panelSubmenuAyuda)
        {
            /// <summary>
            /// Metodo para mostrar los submenus
            /// </summary>
            if (subMenu.Visible == false)
            {
                HideSubMenu(panelSubmenuEjercicios, panelSubmenuEjemplos, panelSubmenuAyuda);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion Metodos de diseño de menu
        #region Metodos Abrir Formularios

        public static void openPanelChildForm(Form childForm, Panel panelContenedor, ref Form activeForm)
        {
            /// <summary>
            /// Metodo para abrir formularios dentro de un panel
            /// </summary>
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion
        public static void SetPlaceholder(TextBox textBox, string placeholder, Color? placeholderColor = null, Color? textColor = null)
        {
            Color phColor = placeholderColor ?? Color.Gray;
            Color normalColor = textColor ?? Color.Black;

            void SetPlaceholderText()
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = phColor;
                }
            }

            void RemovePlaceholderText()
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = normalColor;
                }
            }

            textBox.GotFocus += (s, e) => RemovePlaceholderText();
            textBox.LostFocus += (s, e) => SetPlaceholderText();

            // Inicializar placeholder al cargar
            SetPlaceholderText();
        }
    }
}