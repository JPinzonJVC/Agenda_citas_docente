using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Practica_3
{
    class GestionDB
    {
        string strCon = ConfigurationManager.ConnectionStrings["strCon"].ToString();
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string mensaje = "";

        public GestionDB()
        {
        }

        public void Conectar()
        {
            try
            {
                connection = new SqlConnection(strCon);
                connection.Open();
            }catch (Exception exc)
            {
                mensaje = "No es posible conectarse a la base de datos po " + exc.Message;
            }
        }

        public override string ToString()
        {
            return mensaje;
        }

        public List<string> ListarDocentes()
        {
            List<string> Docentes = new List<string>();
            try
            {
                Conectar();
                string query = "select * from Docente";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ed = reader.GetString(1);
                    Docentes.Add(ed);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }

            return Docentes;
        }

        public List<Cita> ListarCitas()
        {
            List<Cita> Citas = new List<Cita>();
            try
            {
                Conectar();
                string query = "select * from Cita";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cita cita = new Cita();
                    cita.nombre_est = reader.GetString(1);
                    cita.fecha_deseada = reader.GetDateTime(2);
                    cita.docente = reader.GetInt32(3);
                    cita.hora = reader.GetTimeSpan(4);
                    cita.tema = reader.GetString(5);
                    Citas.Add(cita);
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }

            return Citas;
        }

        public int GuardarCita(Cita cita)
        {
            int index = -1;
            try
            {
                Conectar();
                string query = "insert into Cita(Nombre_est, Fecha_deseada, Docente, Hora, Tema)" +
                    "values(@Nombre_est, @Fecha_deseada, @Docente, @Hora, @Tema)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre_est", cita.nombre_est);
                command.Parameters.AddWithValue("@Fecha_deseada", cita.fecha_deseada);
                command.Parameters.AddWithValue("@Docente", cita.docente);
                command.Parameters.AddWithValue("@Hora", cita.hora);
                command.Parameters.AddWithValue("@Tema", cita.tema);
                index = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            connection.Close();

            return index;
        }

        public List<Cita> BuscarFecha(DateTime fecha)
        {
            List<Cita> Citas = new List<Cita>();
            try
            {
                Conectar();
                string query = "select * from Cita c inner join Docente doc on c.Docente = doc.id_doc Where(Fecha_deseada = @Fecha_deseada)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Fecha_deseada", fecha);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetDateTime(2) == fecha)
                    {
                        Cita cita = new Cita();
                        cita.nombre_est = reader.GetString(1);
                        cita.fecha_deseada = reader.GetDateTime(2);
                        cita.docente = reader.GetInt32(3);
                        cita.hora = reader.GetTimeSpan(4);
                        cita.tema = reader.GetString(5);
                        cita.nom_docente = reader.GetString(7);
                        Citas.Add(cita);
                    }
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }

            return Citas;
        }

        public List<Cita> BuscarDoc(int id_doc)
        {
            List<Cita> Citas = new List<Cita>();
            try
            {
                Conectar();
                string query = "select * from Cita c inner join Docente doc on c.Docente = doc.id_doc Where(docente = @id_doc)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_doc", id_doc);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(3) == id_doc)
                    {
                        Cita cita = new Cita();
                        cita.nombre_est = reader.GetString(1);
                        cita.fecha_deseada = reader.GetDateTime(2);
                        cita.docente = reader.GetInt32(3);
                        cita.hora = reader.GetTimeSpan(4);
                        cita.tema = reader.GetString(5);
                        cita.nom_docente = reader.GetString(7);
                        Citas.Add(cita);
                    }
                }
                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                mensaje = e.Message;
            }

            return Citas;
        }



    }
}
