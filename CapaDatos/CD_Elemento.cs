using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CapaDatos
{
    public class CD_Elemento
    {
        public List<Elemento> Listar()
        {
            List<Elemento> lista = new List<Elemento>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select e.Id_elemento,e.Tipo_elemento,c.Descripcion as Categoria,e.Placa,e.Ambiente,s.Descripcion as Estado,e.ValorObjeto,d.Descripcion as Disponibilidad from ELEMENTO e");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = e.Id_categoria");
                    query.AppendLine("inner join ESTADO s on s.IdEstado = e.Estado");
                    query.AppendLine("inner join DISPONIBILIDAD d on d.IdDispo = e.Disponibilidad");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Elemento()
                            {
                                IdElemento = Convert.ToInt32(dr["IdElemento"]),
                                Tipo_elemento = dr["Tipo_Elemento"].ToString(),
                                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["Descripcion"].ToString() },
                                Placa = dr["Placa"].ToString(),
                                oAmbiente = new Ambiente() { IdAmbiente = Convert.ToInt32(dr["IdAmbiente"]), Descripcion = dr["Descripcion"].ToString() },
                                oEstado = new Estado() { IdEstado = Convert.ToInt32(dr["IdEstado"]), Descripcion = dr["Descripcion"].ToString() },
                                ValorObjeto = Convert.ToInt32(dr["ValorObjeto"]),
                                Marca = dr["Descripcion"].ToString(),
                                oDisponibilidad = new Disponibilidad() { IdDispo = Convert.ToInt32(dr["IdDispo"]), Descripcion = dr["Descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Elemento>();
                }
            }
            return lista;
        }
        public int Registrar(Elemento obj, out string Mensaje)
        {
            int idelementogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.Cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAROBJETO", oconexion);

                    cmd.Parameters.AddWithValue("Tipo_Elemento", obj.Tipo_elemento);
                    cmd.Parameters.AddWithValue("Categoria", obj.oCategoria);
                    cmd.Parameters.AddWithValue("Placa", obj.Placa);
                    cmd.Parameters.AddWithValue("Ambiente", obj.oAmbiente);
                    cmd.Parameters.AddWithValue("Estado", obj.oEstado);
                    cmd.Parameters.AddWithValue("ValorObjeto", obj.ValorObjeto);
                    cmd.Parameters.AddWithValue("Marca", obj.Marca);
                    cmd.Parameters.AddWithValue("Disponibilidad", obj.oDisponibilidad);
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idelementogenerado = Convert.ToInt32(cmd.Parameters["IdEstadoGenerado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                idelementogenerado = 0;
                Mensaje = ex.Message;
            }

            return idelementogenerado;

        }
    }
}
