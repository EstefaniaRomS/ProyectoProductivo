using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ambiente
    {
        private CD_Ambiente objcd_ambiente = new CD_Ambiente();
        public List<Ambiente> Listar()
        {
            return objcd_ambiente.Listar();
        }
    }
}
