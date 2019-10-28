using System.Collections.Generic;

namespace Alumnos
{
    public class Controller
    {
        public static void ConnectBD() => Conexion.ObtenerConexion();

        public static List<Alumno> MostrarAlumnos() => Conexion.Buscar();

        public static void EliminarAlumno(int reg) => Conexion.Delete(reg);

        public static void AnyadirAlumno(string dni,
                                         string nombre,
                                         string apellido1,
                                         string apellido2)
        {
            Conexion.Anyadir(dni, nombre, apellido1, apellido2);
        }
    }
}
