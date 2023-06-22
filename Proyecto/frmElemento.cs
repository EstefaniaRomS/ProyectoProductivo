using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtelemento.Select();

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

            List<Ambiente> listaAmbiente = new CN_Ambiente().Listar();
            foreach (Ambiente item in listaAmbiente)
            {
                comboambiente.Items.Add(new OpcionCombo() { Valor = Convert.ToInt32(item.IdAmbiente), Texto = item.Descripcion });
            }
            comboambiente.DisplayMember = "Texto";
            comboambiente.ValueMember = "Valor";
            comboambiente.SelectedIndex = 0;

            List<Estado> listaEstado = new CN_Estado().Listar();
            foreach (Estado item in listaEstado)
            {
                comboestado.Items.Add(new OpcionCombo() { Valor = Convert.ToInt32(item.IdEstado), Texto = item.Descripcion });
            }
            comboestado.DisplayMember = "Texto";
            comboestado.ValueMember = "Valor";
            comboestado.SelectedIndex = 0;

            //Mostar
            List<Elemento> listaElemento = new CN_Elemento().Listar();
            foreach (Elemento item in listaElemento)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdElemento,item.Tipo_elemento,
                    //item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Placa,
                    item.ValorObjeto,
                    item.Marca,
                    //item.oEstado.IdEstado,
                    item.oEstado.Descripcion,
                    //item.oAmbiente.IdAmbiente,
                    item.oAmbiente.Descripcion,
                    //item.oDisponibilidad.IdDispo,
                    item.oDisponibilidad.Descripcion
                });
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txtelemento.Text = "";
            comboestado.SelectedIndex = 0;
            txtmarca.Text = "";
            comboambiente.SelectedIndex = 0;
            txtplaca.Text = "";
            combodisponibilidad.SelectedIndex = 0;
            txtvalor.Text = "";
            combocategoria.SelectedIndex = 0;
            txtelemento.Select();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Elemento objelemento = new Elemento()
            {
                //IdElemento = Convert.ToInt32(txtidelemento.Text),
                Tipo_elemento = txtelemento.Text.ToString(),
                Placa = txtplaca.Text.ToString(),
                oAmbiente = new Ambiente() { IdAmbiente = Convert.ToInt32(((OpcionCombo)comboambiente.SelectedItem).Valor) },
                Marca = txtmarca.Text.ToString(),
                ValorObjeto = Convert.ToInt32(txtvalor.Text),
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)combocategoria.SelectedItem).Valor) },
                oEstado = new Estado() { IdEstado = Convert.ToInt32(((OpcionCombo)comboestado.SelectedItem).Valor) },
                oDisponibilidad = new Disponibilidad() { IdDispo = Convert.ToInt32(((OpcionCombo)combodisponibilidad.SelectedItem).Valor) }
            };
            int idelementogenerado = new CN_Elemento().Registrar(objelemento, out mensaje);

            if (idelementogenerado == 0)
            {
                dgvdata.Rows.Add(new object[] {"",idelementogenerado,txtelemento.Text,txtplaca.Text,txtvalor.Text,txtmarca.Text,
                ((OpcionCombo)combocategoria.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboambiente.SelectedItem).Texto.ToString(),
                ((OpcionCombo)comboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)combodisponibilidad.SelectedItem).Texto.ToString()
                });
            }
            /*
            if (objelemento.IdElemento == 0)
            {
                int idelementogenerado = new CN_Elemento().Registrar(objelemento, out mensaje);

                if (idelementogenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",idelementogenerado,txtelemento.Text,txtplaca.Text,txtvalor.Text,txtmarca.Text,
                ((OpcionCombo)combocategoria.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboambiente.SelectedItem).Texto.ToString(),
                ((OpcionCombo)comboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)combodisponibilidad.SelectedItem).Texto.ToString()
                });
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show(mensaje);
                
                //bool resultado = new CN_Elemento().Editar(objelemento, out mensaje);
                if (resultado == true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();
            }
                
                else
                {
                    MessageBox.Show(mensaje);
                }*/
            Limpiar();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtidelemento.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtelemento.Text = dgvdata.Rows[indice].Cells["Tipo"].Value.ToString();
                    txtplaca.Text = dgvdata.Rows[indice].Cells["Placa"].Value.ToString();
                    txtvalor.Text = dgvdata.Rows[indice].Cells["Valor"].Value.ToString();
                    txtmarca.Text = dgvdata.Rows[indice].Cells["Marca"].Value.ToString();

                    foreach (OpcionCombo oc in comboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Id"].Value))
                        {
                            int indiceCombo = comboestado.Items.IndexOf(oc);
                            comboestado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in comboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Estado"].Value))
                        {
                            int indiceCombo = comboestado.Items.IndexOf(oc);
                            comboestado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                }
            }
        }
    }
}
