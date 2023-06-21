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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdRol, Descripcion from ROL");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }
            return lista;
        }
        public int Registrar(Rol obj, out string Mensaje)
        {
            int idrolgenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARROL", oconexion);

                    cmd.Parameters.AddWithValue("Descripcion", obj.Descripcion);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idrolgenerado = Convert.ToInt32(cmd.Parameters["IdRolGenerado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idrolgenerado = 0;
                Mensaje = ex.Message;
            }

            return idrolgenerado;

        }
    }
}
