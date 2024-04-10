using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        private List<Articulo> listaArticulos;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Categoria");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void CargarGrilla()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.ListarArticulos();
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnas();
                CargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAltaArticulo formAltaArticulo = new FormAltaArticulo();
            formAltaArticulo.ShowDialog();
            CargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormAltaArticulo formAltaArticulo = new FormAltaArticulo(articulo);
            formAltaArticulo.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articulo;
            try
            {
                DialogResult respuesta = MessageBox.Show("El articulo se eliminara de manera permanente ¿Estas de acuerdo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    articuloNegocio.EliminarArticulo(articulo.Id);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarFiltro()
        {
            if (cmbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cmbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cmbCampo.SelectedItem.ToString() == "Nombre")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Por favor, ingrese el filtro.");
                    return true;
                }
            }
            if (cmbCampo.SelectedItem.ToString() == "Categoria")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Por favor, ingrese el filtro.");
                    return true;
                }
            }
            return false;
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (ValidarFiltro() == false)
                {
                    string campo = cmbCampo.SelectedItem.ToString();
                    string criterio = cmbCriterio.SelectedItem.ToString();
                    string filtro = txtFiltro.Text;
                    dgvArticulos.DataSource = articuloNegocio.FiltrarArticulos(campo, criterio, filtro);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.SelectedItem != null)
            {
                string opcion = cmbCampo.SelectedItem.ToString();
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Comienza con");
                cmbCriterio.Items.Add("Termina con");
                cmbCriterio.Items.Add("Contiene");
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            cmbCampo.SelectedIndex = -1;
            cmbCriterio.SelectedIndex = -1;
            txtFiltro.Text = "";
            CargarGrilla();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormArticuloDetalles formArticuloDetalles = new FormArticuloDetalles(articulo);
            formArticuloDetalles.ShowDialog();
        }
    }
}
