using System;
using System.Collections.Generic;
using System.Text;

namespace Alumnos
{
    public class Alumno
    {
        private int registro;
        public int Registro
        {
            get { return registro; }
            set { registro = value; }
        }

        private string dni;
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido1;
        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        private string apellido2;
        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public Alumno(int registro, string dni, string nombre, string apellido1, string apellido2)
        {
            this.registro = registro;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.Apellido2 = apellido2;
        }

        public Alumno()
        {}
    }
}
