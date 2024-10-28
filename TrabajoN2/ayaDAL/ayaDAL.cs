using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ayaBOL;
using System.Data.SqlClient;

namespace ayaDAL
{
    public class ayaDAL
    {
        //Conexion a la base de datos
        private string connectionString = "Data Source=Kevin\\SQLEXPRESS;Initial Catalog=AyA;Integrated Security=True;";

        //Este es un metodo para insertar un nuevo alumno a la base de datos
        public void InsertarAlumno(Alumnos alumnos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Alumnos ( Nombre, ApellidoPat, ApellidoMat, Email, NumeroMatricula) " +
                               "VALUES ( @NombreAlumno, @ApellidoPatAlumno, @ApellidoMatAlumno, @Email, @NumeroMatricula)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@NombreAlumno", alumnos.NombreAlumno ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ApellidoPatAlumno", alumnos.ApellidoPatAlumno ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@ApellidoMatAlumno", alumnos.ApellidoMatAlumno ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Email", alumnos.Email ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@NumeroMatricula", alumnos.NumeroMatricula == 0 ? (object)DBNull.Value : alumnos.NumeroMatricula);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        //Metodo para modificar los datos de un alumno que ya se encuentre dentro de la base de datos
        public void ModificarAlumnos(Alumnos alumnos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();//abre la conexion con la base de datos
                string query = "UPDATE Alumnos SET " +
                        "NombreAlumno = @Nombre, " +
                        "IdAlumno = @IdAlumno, " +
                        "ApellidoPat = @ApellidoPatAlumno, " +
                        "ApellidoMat = @ApellidoMatAlumno, " +
                        "Email = @Email," +
                        "NumeroMatricula = @NumeroMatricula";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAlumno", alumnos.IdAlumno);
                    command.Parameters.AddWithValue("@Nombre", alumnos.NombreAlumno ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoPat", alumnos.ApellidoPatAlumno ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ApellidoMat", alumnos.ApellidoMatAlumno ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Email", alumnos.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NumeroMatricula", alumnos.NumeroMatricula);

                    command.ExecuteNonQuery();
                }
            }
        }


        //Metodo para elminar un alumno que se encuentre dentro de la Base de datos
        public int EliminarAlumno(int id)
        {
            int resultado = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Alumnos WHERE IdAlumno = @IdAlumno";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdAlumno", id);
                    resultado = command.ExecuteNonQuery();
                }
            }
            return resultado;
        }



        //Este metodo guarda en una lista todos los alumnos qu esten dentro de la base de datos
        public List<Alumnos> SeleccionarTodos()
        {
            List<Alumnos> lista = new List<Alumnos>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IdAlumno, Nombre, ApellidoPat, ApellidoMat, Email, NumeroMatricula FROM Alumnos";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())//Recorre los resultados saltados anteriormente
                    {
                        Alumnos alumno = new Alumnos
                        {
                            IdAlumno = dr.GetInt32(0),
                            NombreAlumno = dr.GetString(1),
                            ApellidoPatAlumno = dr.GetString(2),
                            ApellidoMatAlumno = dr.GetString(3),
                            Email = dr.GetString(4),
                            NumeroMatricula = dr.GetInt32(5)
                        };
                        lista.Add(alumno);
                    }
                }
            }
            return lista;
        }

        //Metodo para insertar una nueva asignatura dentro de la base de datos
        public void InsertarAsignatura(Asignatura asignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Asignatura (NombreAsignatura, Creditos) " +
                               "VALUES (@NombreAsignatura, @Creditos)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
                    command.ExecuteNonQuery();
                }
            }
        }
        // Método para modificar los datos de una asignatura existente en la base de datos
        public void ModificarAsignatura(Asignatura asignatura)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Asignatura SET NombreAsignatura = @NombreAsignatura, Creditos = @Creditos " +
                               "WHERE CodAsignatura = @CodigoAsignatura";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoAsignatura", asignatura.CodAsignatura);
                    command.Parameters.AddWithValue("@NombreAsignatura", asignatura.NombreAsignatura ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
                    command.ExecuteNonQuery();
                }
            }
        }
       //Metodo para Elinar una asignatura ya ingresada dentro de la base de datos
        public int EliminarAsignatura(int codigoAsignatura)
        {
            int resultado;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Asignatura WHERE CodAsignatura = @CodigoAsignatura";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoAsignatura", codigoAsignatura);
                    resultado = command.ExecuteNonQuery();
                }
            }
            return resultado;
        }
        //Metodo que Devuelve una lista con todas las asignatura registradas dentro de la base de datos
        public List<Asignatura> SeleccionarTodasAsignaturas()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CodAsignatura, NombreAsignatura, Creditos FROM Asignatura";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Asignatura asignatura = new Asignatura
                        {
                            CodAsignatura = reader.GetInt32(0),
                            NombreAsignatura = reader.GetString(1),
                            Creditos = reader.GetInt32(2)
                        };
                        listaAsignaturas.Add(asignatura);
                    }
                }
            }
            return listaAsignaturas;
        }
    }
}





