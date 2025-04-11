using System;
using System.Data.SqlClient;

namespace MIBasedeU.Clases
{
    public class Crud
    {
        string connectionString = "Server=DESKTOP-OQRPO5C\\SQLEXPRESS01;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";
        public string mostrarinfo(string carnet)
        {
            string nombre = "No existe";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select * from TB_alumnos where carnet = '{carnet}'";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        nombre = reader["Estudiante"].ToString();
                        // Console.WriteLine($"Carnet {reader["carnet"]}, nombre {reader["Estudiante"]}, seccion {reader["seccion"]} Correo {reader["email"]}");
                    }
                }
                catch (Exception)
                {
                    nombre = "Error";
                    // Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
                return nombre;

            }
        }
        public string agregaralumno(string carnet, string nombre, string email, string seccion)
        {


            string respuesta = "No se pudo insertar el alumno";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "insert into TB_alumnos (carnet, Estudiante, email, seccion ) values (@carnet,@nombre,@email,@seccion)";
                try
                {


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                    respuesta = "Alumno insertado correctamente";

                }
                catch (Exception ex)
                {
                    respuesta = "Error: " + ex.Message;
                }
                connection.Close();


            }
            return respuesta;
        }
        public void Actulizaralumno(string carnet, string nombre)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "update TB_alumnos set Estudiante=@nombre where carnet=@carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@carnet", carnet);


                    connection.Open();
                    command.ExecuteNonQuery();


                }
                catch (Exception ex)
                {

                }
                connection.Close();


            }
        }
    }
}
