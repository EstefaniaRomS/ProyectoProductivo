using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace Proyecto
{
    public partial class frmElemento : Form
    {
        public frmElemento()
        {
            InitializeComponent();
        }

        private void frmElemento_Load(object sender, EventArgs e)
        {
            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                combocategoria.Items.Add(new OpcionCombo() { Valor = Convert.ToInt32(item.IdCategoria), Texto = item.Descripcion });
            }
            combocategoria.DisplayMember = "Texto";
            combocategoria.ValueMember = "Valor";
            combocategoria.SelectedIndex = 0;

            
            List<Disponibilidad> listaDisponibilidad = new CN_Disponibilidad().Listar();
            foreach (Disponibilidad item in listaDisponibilidad)
            {
                combodisponibilidad.Items.Add(new OpcionCombo() { Valor = Convert.ToInt32(item.IdDispo), Texto = item.Descripcion });
            }
            combodisponibilidad.DisplayMember = "Texto";
            combodisponibilidad.ValueMember = "Valor";
            combodisponibilidad.SelectedIndex = 0;

            /*
            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;*/
        }
    }
}
