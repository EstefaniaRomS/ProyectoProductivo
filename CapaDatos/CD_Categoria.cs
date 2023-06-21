using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCategoria, Descripcion from CATEGORIA");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }
        public int Registrar(Categoria obj, out string Mensaje)
        {
            int idcategoriagenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCATEGORIA", oconexion);

                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idcategoriagenerada = Convert.ToInt32(cmd.Parameters["IdCategoriaGenerada"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idcategoriagenerada = 0;
                Mensaje = ex.Message;
            }

            return idcategoriagenerada;

        }
    }
}
