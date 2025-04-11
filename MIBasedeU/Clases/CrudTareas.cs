using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MIBasedeU.Clases.CrudTareas;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.NetworkInformation;

namespace MIBasedeU.Clases
{
    public class CrudTareas
    {
        private static string connectionString = "Server=DESKTOP-OQRPO5C\\SQLEXPRESS01;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";
        public class Notas
        {
            public string Nota1 { get; set; }
            public string Nota2 { get; set; }
            public string Nota3 { get; set; }
            public string Nota4 { get; set; }
        }

        public static Notas BuscarTareas(string carnet)
        {
            Notas tarea = new Notas();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"select nota1,nota2,nota3,nota4 from tareas where Carnet= @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        tarea = new Notas
                        {
                            Nota1 = reader["nota1"].ToString(),
                            Nota2 = reader["nota2"].ToString(),
                            Nota3 = reader["nota3"].ToString(),
                            Nota4 = reader["nota4"].ToString()
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
                return tarea;
            }
        }
        public string agregartarea(string carnet, string nota1, string nota2, string nota3, string nota4) {
            string respuesta = "No se pudo insertar el la nota";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "insert into tareas (carnet,nota1,nota2,nota3,nota4)values(@carnet,@nota1,@nota2,@nota3,@nota4)";
                try
                {


                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    connection.Open();
                    command.ExecuteNonQuery();
                    respuesta = "Notas insertado correctamente";

                }
                catch (Exception ex)
                {
                    respuesta = "Error: " + ex.Message;
                }
                connection.Close();


            }
            return respuesta;


        }
    }
}
