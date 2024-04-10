using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormArticuloDetalles : Form
    {
        private Articulo articulo;
        public FormArticuloDetalles(Articulo articulo1)
        {
            InitializeComponent();
            articulo = articulo1;
        }

        private void FormArticuloDetalles_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = articulo.Codigo;
            rtbDescripcion.Text = articulo.Descripcion;

            txtCodigo.Enabled = false;
            rtbDescripcion.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
