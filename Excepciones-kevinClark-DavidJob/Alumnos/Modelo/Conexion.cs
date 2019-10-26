using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Alumnos
{
    public class Conexion
    {
        public static MySqlConnection conectar;
        public static void ObtenerConexion()
        {
            conectar = new MySqlConnection("server=127.0.0.1; database=libros; Uid=root; pwd=X7544216-d;");
            Console.WriteLine("conexión");
        }

        public static List<Alumno> Buscar()
        {
            conectar.Open();
            List<Alumno> lista = new List<Alumno>();

            MySqlCommand comando = new MySqlCommand(string.Format("Select * From alumnos"), conectar);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Alumno aux = new Alumno();
                aux.Registro = reader.GetInt32(0);
                aux.Dni = reader.GetString(1);
                aux.Nombre = reader.GetString(2);
                aux.Apellido1 = reader.GetString(3);
                aux.Apellido2 = reader.GetString(4);
                lista.Add(aux);
            }
            conectar.Close();
            return lista;
            
        }

        public static void Delete(int reg)
        {
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From alumnos where registro={0}", reg), conectar);

            comando.ExecuteNonQuery();

            conectar.Close();
        }
        
        public static void Anadir(string dni, string nombre, string apellido1, string apellido2)
        {
            conectar.Open();

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Alumnos values (null,'{0}','{1}','{2}','{3}')", dni, nombre, apellido1, apellido2), conectar);

            comando.ExecuteNonQuery();

            conectar.Close();
        }
    }
}
