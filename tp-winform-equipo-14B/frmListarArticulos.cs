using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp_winform_equipo_14B
{
    public partial class frmListarArticulos : Form
    {
        private List<Articulo> ListaArticulo;
        public frmListarArticulos()
        {
            InitializeComponent();
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            ListaArticulo = articulo.listar();
            dgvListarArticulos.DataSource = ListaArticulo;

        }
    }
}
