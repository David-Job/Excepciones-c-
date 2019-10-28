using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Alumnos
{
    public class Conexion
    {
        public static MySqlConnection MySQL { get; set; }

        public static void ObtenerConexion()
        {
            MySQL = new MySqlConnection("server=127.0.0.1; database=libros; Uid=root; pwd=X7544216-d;");
            Console.WriteLine("conexión");
        }

        public static List<Alumno> Buscar()
        {
            MySQL.Open();
            List<Alumno> lista = new List<Alumno>();

            using (MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM alumnos"), MySQL))
            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Alumno
                    {
                        Registro = reader.GetInt32(0),
                        Dni = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        Apellido1 = reader.GetString(3),
                        Apellido2 = reader.GetString(4)
                    });
                }
            }

            MySQL.Close();
            return lista;
        }

        public static void Delete(int reg)
        {
            MySQL.Open();
            new MySqlCommand(string.Format("DELETE FROM alumnos WHERE registro={0}", reg), MySQL).ExecuteNonQuery();
            MySQL.Close();
        }

        public static void Anyadir(string dni,
                                   string nombre,
                                   string apellido1,
                                   string apellido2)
        {
            MySQL.Open();
            using (MySqlCommand mySqlCommand =
                new MySqlCommand(string.Format("Insert into Alumnos values (null,'{0}','{1}','{2}','{3}')", dni, nombre, apellido1, apellido2), MySQL))
            {
                mySqlCommand.ExecuteNonQuery();
            }
            MySQL.Close();
        }
    }
}
