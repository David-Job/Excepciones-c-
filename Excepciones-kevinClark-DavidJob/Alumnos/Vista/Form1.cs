using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumnos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller.ConnectBD();
            dataGridView1.DataSource = Controller.MostrarAlumnos();
        }

        private void anadir_button_Click(object sender, EventArgs e)
        {
            if (textBox_dni.Text.Equals("") || textBox_nombre.Text.Equals("") || 
                textBox_apellido1.Text.Equals("") )
            {
                data_error_label.Text = "No deje campos sin rellenar";
            }
            else
            {
                Controller.AnadirAlumno(textBox_dni.Text, textBox_nombre.Text, textBox_apellido1.Text, textBox_apellido2.Text);
                dataGridView1.DataSource = Controller.MostrarAlumnos();
                textBox_dni.Text = "";
                textBox_nombre.Text = "";
                textBox_apellido1.Text = "";
                textBox_apellido2.Text = "";
                data_error_label.Text = "";
            }   
        }
        private void button_eliminar_Click(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = Int32.Parse(textBox1.Text);
                if (n <= 0)
                {
                    label_ERROR.Text = "Introduzca un número positivo";
                }
                else
                {
                    Controller.EliminarAlumno(n);
                    dataGridView1.DataSource = Controller.MostrarAlumnos();
                    label_ERROR.Text = "";
                    textBox1.Text = "";
                }


            }
            catch (FormatException)
            {
                label_ERROR.Text = "Introduzca un valor númerico";
            }

        }
    }
}
