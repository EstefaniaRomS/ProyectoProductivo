using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Elemento
    {
        public int IdElemento { get; set; }
        public TipoElemento oTipoElemento { get; set; }
        public Categoria oCategoria{ get; set; }
        public string Placa { get; set; }
        public int Ambiente { get; set; }
        public int Estado { get; set; }
        public int ValorELemento { get; set; }
        public string Marca { get; set; }
        public Disponibilidad oDisponibilidad { get; set; }
        public string FechaRegistro { get; set; }
    }
}
