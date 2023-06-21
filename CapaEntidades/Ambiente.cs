using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Ambiente
    {
        public int IdAmbiente { get; set; }
        public string Descripcion { get; set; }
        public int IdNave { get; set; }
        public int IdCentro { get; set; }
    }
}
