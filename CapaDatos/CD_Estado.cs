using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Estado
    {
        public List<Estado> Listar()
        {
            List<Estado> lista = new List<Estado>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdEstado, Descripcion from ESTADO");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Estado()
                            {
                                IdEstado = Convert.ToInt32(dr["IdEstado"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Estado>();
                }
            }
            return lista;
        }
        public int Registrar(Estado obj, out string Mensaje)
        {
            int idestadogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARESTADO", oconexion);

                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idestadogenerado = Convert.ToInt32(cmd.Parameters["IdEstadoGenerado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idestadogenerado = 0;
                Mensaje = ex.Message;
            }

            return idestadogenerado;

        }

    }
}
