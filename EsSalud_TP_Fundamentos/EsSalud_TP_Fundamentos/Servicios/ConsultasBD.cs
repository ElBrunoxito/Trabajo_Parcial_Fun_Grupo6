using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using EsSalud_TP_Fundamentos.Entidades;
using System.Runtime.Intrinsics.X86;
using System.Collections;
using System.Drawing;
using System.Globalization;

namespace EsSalud_TP_Fundamentos.Servicios
{
    class ConsultasBD
    {
        string Server = "Server=DESKTOP-JNORH5V\\SQLEXPRESS";
        string DataBase = "database=TP_Fundamentos";

        public void AddPaciente(Paciente p)
        {
            //string conexion = Server + ";"+DataBase+";Integrated Security=True";
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            //string conexion= "Data Source=localhost;Initial Catalog=TP_Fundamentos;Integrated Security=True; TrustServerCertificate =True";

            string Query = "INSERT INTO Paciente VALUES('" + p.DNI + "', '" + p.Nombre + "','" + p.Apellidos + "',@fecha,'" + p.Genero + "','" + p.Direccion + "','" + p.Telefono + "','" + p.Correo + "', @imagen , '"+p.CoE+"')";
            try
            {
                using (SqlConnection sqlConnection1 = new SqlConnection(conexion))
                {
                    sqlConnection1.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlConnection1)) 
                    { 
                     
                        ImageConverter converter = new ImageConverter();
                        byte[] imageBytes = (byte[])converter.ConvertTo(p.Avatar, typeof(byte[]));
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = p.FechaNacimiento.Date.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = imageBytes;
                        
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Introducido");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Clipboard.SetText(ex.Message);
            }
           







            /*
            SqlConnection cn = new SqlConnection(conexion))
            
                string SQLQUERY = "INSERT INTO Paciente VALUES('"+ p.DNI + "', '"+p.Nombre+"','"+p.Apellidos+"',@fecha,'"+p.Genero+"','"+ p.Direccion+"','"+p.Telefono+"','"+p.Correo+"', @imagen)";

                using(SqlCommand cmd = new SqlCommand(SQLQUERY, cn))
                {
                    cmd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = p.Avatar;
                    cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = p.FechaNacimiento;
                    cmd.CommandType = CommandType.Text;


                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            */


        }
        public void AddCita(Cita c)
        {
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";

            string Query = "INSERT INTO Citas_Medicas (Fecha, Hora, Duracion, estadoDeLaCita, Paciente_DNI, HospitalMedico_Medico_idMedico, HospitalMedico_Hospital_idHospital) " +
                           "VALUES (@fecha, @hora,@duracion,'" + c.Estado +"','" + c.idPaciente + "','" + c.idMedico + "','" + c.idHospital + "')";
            try
            {
                using (SqlConnection sqlConnection1 = new SqlConnection(conexion))
                {
                    sqlConnection1.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, sqlConnection1))
                    {

                        //cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = p.FechaNacimiento.Date.ToString("yyyy-MM-dd");
                        //cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = c.fecha.Date.ToString("yyyy-MM-dd"); ;
                        //cmd.Parameters.Add("@hora", SqlDbType.Time).Value = c.hora.TimeOfDay;
                        //cmd.Parameters.Add("@duracion", SqlDbType.Time).Value = c.Duracion.TimeOfDay;
                        //cmd.Parameters.AddWithValue("@fecha",c.fecha.Date);
                        //cmd.Parameters.AddWithValue("@hora",c.hora);
                        //cmd.Parameters.AddWithValue("@duracion", c.Duracion);
                        /*cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = c.fecha;
                        cmd.Parameters.Add("@hora", SqlDbType.Time).Value = c.hora;
                        cmd.Parameters.Add("@duracion", SqlDbType.Time).Value = c.Duracion;
                        */
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = c.fecha;

                        // Si c.hora es un DateTime, convierte la parte de tiempo a TimeSpan
                        cmd.Parameters.Add("@hora", SqlDbType.Time).Value = c.hora.TimeOfDay;// Convert DateTime to TimeSpan


                        // Si c.Duracion es un TimeSpan, asigna directamente
                        cmd.Parameters.Add("@duracion", SqlDbType.Time).Value = c.Duracion.TimeOfDay;



                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cita reservada");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Clipboard.SetText(ex.Message);
            }
        }
        public List<Paciente> SelectAllPacientes()
        {
            List<Paciente> Ptemp = new();
            string Query = "SELECT * FROM Paciente";
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Paciente pte = new();
                            pte.DNI = reader.GetString(0);
                            pte.Nombre = reader.GetString(1);
                            pte.Apellidos = reader.GetString(2);
                            pte.FechaNacimiento = reader.GetDateTime(3);
                            pte.Genero = reader.GetString(4)[0];
                            pte.Direccion = reader.GetString(5);
                            pte.Telefono = reader.GetString(6);
                            pte.Correo = reader.GetString(7);
                            pte.Avatar = ByteArrayToBitmap(reader["avatar"] as byte[]);
                            pte.CoE = reader.GetString(9);

                            Ptemp.Add(pte);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
                Clipboard.SetText(ex.Message);

            }

            return Ptemp;
        }
        public List<Especialidad> getEspecialidadesExistente()
        {
            List<Especialidad> Etemp = new();
            string Query = "SELECT * FROM Especialidad";
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Especialidad ete = new();
                            ete.id = reader.GetInt32(0);
                            ete.Nombre = reader.GetString(1);
                            ete.Descripcion = reader.GetString(2);


                            Etemp.Add(ete);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return Etemp;

        }
        public List<Hospital> getHospitalesExistentes()
        {
            List<Hospital> l = new();
            string Query = "SELECT * FROM Hospital";


            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Hospital ete = new();
                            ete.ID = reader.GetInt32(0);
                            ete.Nombre = reader.GetString(1);
                            ete.Direccion = reader.GetString(2);
                            ete.Correo = reader.GetString(3);
                            ete.PaginaWeb = reader.GetString(4);
                            ete.FechaFundacion = reader.GetDateTime(5);


                            l.Add(ete);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return l;

        }
        public List<Medico> getMedicosExistentes() {
            List<Medico> Mtemp = new();
            string Query = "SELECT * FROM Medico";
            
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);

                //Medico
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql


                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {                            
                            Medico dte = new();
                            dte.idMedico = reader.GetInt32(0);
                            dte.Nombre = reader.GetString(1);
                            dte.FechaNacimiento = reader.GetDateTime(2);
                            dte.Genero = reader.GetString(3)[0];
                            dte.Telefono = reader.GetString(4);
                            dte.Correo = reader.GetString(5);                           
                            dte.Avatar = ByteArrayToBitmap(reader["avatar"] as byte[]);
                            dte.Especialidades = GetEspecialidadesPorIdMedico(dte.idMedico);
                            Mtemp.Add(dte);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR tmrmedico: " + ex.ToString());
                Clipboard.SetText(ex.Message);

            }

            return Mtemp;

        }
        public List<Especialidad> GetEspecialidadesPorIdMedico(int idMedico)
        {
            string QueryEspecialidad = "SELECT E.idEspecialidad, E.nombre, E.descripcion " +
                           "FROM Especialidad E " +
                           "INNER JOIN MedicoEspecialidad ME ON ME.Especialidad_idEspecialidad = E.idEspecialidad " +
                           "INNER JOIN Medico M ON M.idMedico = ME.Medico_idMedico " +
                           "WHERE M.idMedico = @idMedico";

            List<Especialidad> l = new();            
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                cn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(QueryEspecialidad, cn))
                {
                    //Abrir Conexion
                    //open
                    sqlCommand.Parameters.AddWithValue("@idMedico",idMedico);
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Especialidad ete = new();
                            ete.id = reader.GetInt32(0);
                            ete.Nombre = reader.GetString(1);
                            ete.Descripcion = reader.GetString(2);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR xddddd: " + ex.ToString());
                Clipboard.SetText(ex.Message);

            }

            return l;
        }

        
        public List<Cita> getAllCitas()
        {
            List<Cita> Ptemp = new();
            string Query = "SELECT * FROM Citas_Medicas";
            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cita cte = new();
                            cte.ID = reader.GetInt32(0);
                            cte.fecha = reader.GetDateTime(1);
                            TimeSpan tstemp = reader.GetTimeSpan(2);
                            DateTime dtTemp = DateTime.Now.Date;
                            cte.hora = dtTemp.Add(tstemp);
                            cte.Estado = reader.GetString(3);
                            TimeSpan tstemp1 = reader.GetTimeSpan(4);
                            DateTime dtTemp1 = DateTime.Now.Date;
                            cte.Duracion = dtTemp1.Add(tstemp1);
                            cte.idMedico = reader.GetInt32(6);
                            cte.idHospital = reader.GetInt32(7);
                            
                            Ptemp.Add(cte);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
                Clipboard.SetText(ex.Message);

            }

            return Ptemp;
        }


        //Reserva
        public List<Hospital> getHospitalesPorEspecialidad(int idEspecialidad)
        {
            List<Hospital> l = new();
            string Query = "SELECT DISTINCT H.idHospital,H.nombre,H.direccion,H.correo,H.paginaWeb, H.fechaFundacion" +
                "           FROM Hospital H" +
                "           INNER JOIN HospitalMedico HM ON HM.Hospital_idHospital = H.idHospital" +
                "           INNER JOIN Medico M ON M.idMedico = HM.Medico_idMedico" +
                "           INNER JOIN MedicoEspecialidad ME ON ME.Medico_idMedico = M.idMedico" +
                "           WHERE ME.Especialidad_idEspecialidad = @idEspecialidad";


            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    sqlCommand.Parameters.AddWithValue("@idEspecialidad",idEspecialidad);
                    //Leer Comandos sql
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Hospital ete = new();
                            ete.ID = reader.GetInt32(0);
                            ete.Nombre = reader.GetString(1);
                            ete.Direccion = reader.GetString(2);
                            ete.Correo = reader.GetString(3);
                            ete.PaginaWeb = reader.GetString(4);
                            ete.FechaFundacion = reader.GetDateTime(5);


                            l.Add(ete);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return l;


        }

        public List<Medico> getMedicoPorEspecialidadyHospital(int idEspecialidad,int idHospital)
        {
            List<Medico> Mtemp = new();

            string Query = 
               "SELECT M.idMedico, M.nombreCompleto, M.fechaNacimiento, M.genero, M.telefono, M.correo, M.avatar " +
               "FROM Medico M " +
               "INNER JOIN HospitalMedico HM ON M.idMedico = HM.Medico_idMedico " +
               "WHERE HM.Hospital_idHospital = @idHospital AND M.idMedico IN (" +
               "   SELECT M.idMedico " +
               "   FROM Especialidad E " +
               "   INNER JOIN MedicoEspecialidad ME ON ME.Especialidad_idEspecialidad = E.idEspecialidad " +
               "   INNER JOIN Medico M ON M.idMedico = ME.Medico_idMedico " +
               "   WHERE E.idEspecialidad = @idEspecialidad)";



            string conexion = Server + ";" + DataBase + ";" + "integrated security=True; TrustServerCertificate =True";
            try
            {
                SqlConnection cn = new SqlConnection(conexion);

                //Medico
                using (SqlCommand sqlCommand = new SqlCommand(Query, cn))
                {
                    //Abrir Conexion
                    cn.Open();
                    //Leer Comandos sql
                    sqlCommand.Parameters.AddWithValue("@idHospital", idHospital);
                    sqlCommand.Parameters.AddWithValue("@idEspecialidad", idEspecialidad);


                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medico dte = new();
                            dte.idMedico = reader.GetInt32(0);
                            dte.Nombre = reader.GetString(1);
                            dte.FechaNacimiento = reader.GetDateTime(2);
                            dte.Genero = reader.GetString(3)[0];
                            dte.Telefono = reader.GetString(4);
                            dte.Correo = reader.GetString(5);
                            dte.Avatar = ByteArrayToBitmap(reader["avatar"] as byte[]);
                            dte.Especialidades = GetEspecialidadesPorIdMedico(dte.idMedico);
                            Mtemp.Add(dte);
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR TRMR: " + ex.ToString());
                Clipboard.SetText(ex.Message);

            }

            return Mtemp;



        }

        

        

        static Bitmap ByteArrayToBitmap(byte[] byteArray)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    return new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }


    }
}
