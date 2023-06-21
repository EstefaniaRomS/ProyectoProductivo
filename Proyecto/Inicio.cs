using CapaEntidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static ToolStripMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            System.Collections.IList list = menu.Items;
            for (int i = 2; i < list.Count; i++)
            {
                ToolStripMenuItem iconmenu = (ToolStripMenuItem)list[i];
                iconmenu.Visible = false;
            }
            //lblusuario.Text = usuarioActual.NombreCompleto;
        }
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.WhiteSmoke;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuelemento_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmElemento());
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
