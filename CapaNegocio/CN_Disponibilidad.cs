using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Disponibilidad
    {
        private CD_Disponibilidad objcd_disponibilidad = new CD_Disponibilidad();
        public List<Disponibilidad> Listar()
        {
            return objcd_disponibilidad.Listar();
        }
    }
}
