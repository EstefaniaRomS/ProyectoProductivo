using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Estado
    {
        private CD_Estado objcd_estado = new CD_Estado();
        public List<Estado> Listar()
        {
            return objcd_estado.Listar();
        }
        public int Registrar(Estado obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesario que ingrese una descipcion\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_estado.Registrar(obj, out Mensaje);
            }
        }
    }
}
