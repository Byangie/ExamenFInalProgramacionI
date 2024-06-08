using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using Dapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Crud_Alumnos
{
    public class DataAccess
    {
        public const string CADENA_SQL_SERVER = "Server=DESKTOP-JNQ2MF0\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Alumnos";

        public List<Alumno> GetAllDapper()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT a.IdUsuario, a.Carnet, a.Nombre, a.Telefono, a.Grado, a.Usuario, c.Nombre as Usuario FROM Alumno a JOIN Usuario c ON a.IdUsuario = c.Id";
                alumnos = conn.Query<Alumno>(query).ToList();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return alumnos;

        }

        public int Create(Alumno alumno)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"INSERT INTO Alumno (IdUsuario, Carnet, Nombre, Telefono, Grado, Usuario) VALUES (@IdUsuario, @Carnet, @Nombre, @Telefono, @Grado, @Usuario)";
                //Execute (guardar, eliminar o actualizar)lo que hace es ejecutar, si queres alamacernar datos, recuperar query
                result = conn.Execute(query, new
                {
                    IdUsuario = alumno.IdUsuario,
                    Carnet = alumno.Carnet,
                    Nombre = alumno.Nombre,
                    Telefono = alumno.Telefono,
                    Grado = alumno.Grado,
                    Usuario = alumno.Usuario
                });

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public Alumno GetById(int idAlumno)
        {
            Alumno alumnos = new Alumno();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT IdUsuario, Carnet, Nombre, Telefono, Grado, Usuario FROM Alumno WHERE IdUsuario = @IdUsuario";
                alumnos = conn.QuerySingle<Alumno>(query, new { Id = idAlumno });
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return alumnos;

        }
        public int Update(Alumno alumno)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"UPDATE Alumno SET IdUsuario=@IdUsuario, Carnet=@Carnet, Nombre=@Nombre, Telefono=@Telefono, Grado=@Grado, Usuario=@Usuario WHERE IdUsuario = @IdUsuario";
                //Execute (guardar, eliminar o actualizar)lo que hace es ejecutar, si queres alamacernar datos, recuperar query
                result = conn.Execute(query, new
                {
                    IdUsuario = alumno.IdUsuario,
                    Carnet = alumno.Carnet,
                    Nombre = alumno.Nombre,
                    Telefono = alumno.Telefono,
                    Grado = alumno.Grado,
                    Usuario = alumno.Usuario
                });

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public int Delete(int IdUsuario)
        {
            int result = 0;
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = @"DELETE FROM Alumno WHERE IdUsuario= @IdUsuario";
                //Execute (guardar, eliminar o actualizar)lo que hace es ejecutar, si queres alamacernar datos, recuperar query
                result = conn.Execute(query, new
                {
                    IdUsuario = IdUsuario

                });

                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return result;

        }
        public List<Usuario> GetUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlConnection conn = new SqlConnection(CADENA_SQL_SERVER);
                conn.Open();
                string query = "SELECT Id, nombre FROM Usuario";
                usuarios = conn.Query<Usuario>(query).ToList();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            return usuarios;

        }
    }
}
