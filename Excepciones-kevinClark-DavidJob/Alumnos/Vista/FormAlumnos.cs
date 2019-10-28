using Alumnos;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
            Controller.ConnectBD();
            dataGridViewAlumnos.DataSource = Controller.MostrarAlumnos();
        }

        private void ButtonAnyadirClick(object sender, EventArgs e)
        {
            if (textBoxDni.Text.Equals("") || textBoxNombre.Text.Equals("") ||
                textBoxApellido1.Text.Equals(""))
            {
                labelDataError.Text = "No deje campos sin rellenar";
            }
            else
            {
                Controller.AnyadirAlumno(textBoxDni.Text, textBoxNombre.Text, textBoxApellido1.Text, textBoxApellido2.Text);
                dataGridViewAlumnos.DataSource = Controller.MostrarAlumnos();
                textBoxDni.Text = "";
                textBoxNombre.Text = "";
                textBoxApellido1.Text = "";
                textBoxApellido2.Text = "";
                labelDataError.Text = "";
            }
        }
        private void ButtonEliminarClick(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = Int32.Parse(textBoxRegistro.Text);
                if (n <= 0)
                {
                    labelError.Text = "Introduzca un número positivo";
                }
                else
                {
                    Controller.EliminarAlumno(n);
                    dataGridViewAlumnos.DataSource = Controller.MostrarAlumnos();
                    labelError.Text = "";
                    textBoxRegistro.Text = "";
                }


            }
            catch (FormatException)
            {
                labelError.Text = "Introduzca un valor númerico";
            }

        }
    }
}
