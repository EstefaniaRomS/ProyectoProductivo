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
    public class CD_Disponibilidad
    {
        public List<Disponibilidad> Listar()
        {
            List<Disponibilidad> lista = new List<Disponibilidad>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdDispo, Descripcion from DISPONIBILIDAD");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Disponibilidad()
                            {
                                IdDispo = Convert.ToInt32(dr["IdDispo"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Disponibilidad>();
                }
            }
            return lista;
        }
    }
}
