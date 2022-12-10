using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result Add(ML.Libro libro)
            {
             ML.Result result = new ML.Result();
             try
              {
               using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
               {
                   string query = "INSERT INTO [Libro]([Nombre],[IdAutor],[NumeroPaginas],[FechaPublicacion],[IdEditorial],[Edicion],[IdGenero]) VALUES(@Nombre,@IdAutor,@NumeroPaginas,@FechaPublicacion,@IdEditorial,@Edicion,@IdGenero)";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = libro.Nombre;

                        collection[1] = new SqlParameter("IdAutor", SqlDbType.Int);
                        collection[1].Value = libro.Autor.IdAutor;

                        collection[2] = new SqlParameter("NumeroPaginas", SqlDbType.Int);
                        collection[2].Value = libro.NumeroPaginas;

                        collection[3] = new SqlParameter("FechaPublicacion", SqlDbType.VarChar);
                        collection[3].Value = libro.FechaPublicacion;

                        collection[4] = new SqlParameter("IdEditorial", SqlDbType.Int);
                        collection[4].Value = libro.Editorial.IdEditorial;

                        collection[5] = new SqlParameter("Edicion", SqlDbType.VarChar);
                        collection[5].Value = libro.Edicion;

                        collection[6] = new SqlParameter("IdGenero", SqlDbType.Int);
                        collection[6].Value = libro.Genero.IdGenero;


                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                                result.Message = "Se agrego correctamente el libro";
                        }
                    }

                  }
                    result.Correct = true;
                }
                catch (Exception ex)
                {
                    result.Correct = false;
                    result.Ex = ex;
                    result.Message = "Ocurrio un error al agregar el libro" + result.Ex;
                }
                return result;

          }
        public static ML.Result Delete(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConexion()))
                {
                    string query = "DELETE FROM Libro WHERE IdLibro = @IdLibro";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context; //conexion
                        cmd.CommandText = query; //query

                        context.Open();

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdLibro", SqlDbType.Int);
                        collection[0].Value = libro.IdLibro;

                        cmd.Parameters.AddRange(collection);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected >= 1)
                        {
                            result.Message = "Se elimino el libro correctamente";
                        }

                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.Ex = ex;
                result.Message = "Ocurrio un error al eliminar el Usuario" + result.Ex;
            }
            return result;
        }
    }
}
