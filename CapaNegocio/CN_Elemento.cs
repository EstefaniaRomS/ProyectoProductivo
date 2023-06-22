using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Elemento
    {
        private CD_Elemento objcd_elemento = new CD_Elemento();
        public List<Elemento> Listar()
        {
            return objcd_elemento.Listar();
        }
        public int Registrar(Elemento obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.Tipo_elemento == "")
            {
                Mensaje += "Es necesario que ingrese el tipo de elemento\n";
            }
            if (obj.Placa == "")
            {
                Mensaje += "Es necesario que ingrese la placa del elemento\n";
            }
            if (obj.ValorObjeto == 0)
            {
                Mensaje += "Es necesario que ingrese el valor del elemento\n";
            }
            if (obj.Marca == "")
            {
                Mensaje += "Es necesario que ingrese la marca del elemento\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_elemento.Registrar(obj, out Mensaje);
            }
        }
    }
}
