using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Desactivar los mensajes de error de script en el control WebBrowser
            webBrowser1.ScriptErrorsSuppressed = true;

            // Cargar una página web en el control WebBrowser al iniciarse la aplicación
            webBrowser1.Navigate("https://theuselessweb.site/icantsleep/");

            // Configurar el botón para que tenga un estilo plano y un color de fondo amarillo
            btnNavegador.FlatStyle = FlatStyle.Flat;
            btnNavegador.BackColor = Color.FromArgb(255, 255, 0);
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            // Cargar una página web diferente en el control WebBrowser al hacer clic en el botón
            webBrowser1.Navigate("https://www.google.com/webhp?hl=es&sa=X&ved=0ahUKEwjtsbnhza_-AhVdTTABHQzgC2IQPAgI");

            // Ocultar el botón después de hacer clic en él
            btnNavegador.Visible = false;

            // Activar la opción de maximizar el formulario cuando se haga clic en el botón
            this.MaximizeBox = true;

            // Poner los bordes de vuelta al formulario
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Desactivar la opción de maximizar el formulario al cargarlo
            this.MaximizeBox = false;

            // Poner el formulario en modo ventana sin bordes
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
