using System;
using System.Collections.Generic;
using System.Text;
using Alumnos;


namespace Alumnos
{
    public class Controller
    {
        public static void ConnectBD()
        {
                Conexion.ObtenerConexion();
        }

        public static List<Alumno> MostrarAlumnos()
        {
            return Conexion.Buscar();
        }

        public static void EliminarAlumno(int reg)
        {
            Conexion.Delete(reg);
        }

        public static void AnadirAlumno(string dni, string nombre, string apellido1, string apellido2)
        {
            Conexion.Anadir(dni, nombre, apellido1, apellido2);
        }
    }
}
