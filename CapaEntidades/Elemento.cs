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
        public string Tipo_elemento { get; set; }
        public Categoria oCategoria{ get; set; }
        public string Placa { get; set; }
        public Ambiente oAmbiente{ get; set; }
        public Estado oEstado{ get; set; }
        public int ValorObjeto { get; set; }
        public string Marca { get; set; }
        public Disponibilidad oDisponibilidad { get; set; }
        public string FechaRegistro { get; set; }
    }
}
