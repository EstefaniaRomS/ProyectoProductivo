using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();
        public List<Categoria> Listar()
        {
            return objcd_categoria.Listar();
        }
        public int Registrar(Categoria obj, out string Mensaje)
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
                return objcd_categoria.Registrar(obj, out Mensaje);
            }
        }
    }
}
