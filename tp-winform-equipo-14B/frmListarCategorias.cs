using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_14B
{
    public partial class frmListarCategorias : Form
    {
        private List<Categoria> ListaCategorias;
        public frmListarCategorias()
        {
            InitializeComponent();
        }

        private void frmListarCategorias_Load(object sender, EventArgs e)
        {
         
                CategoriaNegocio cat = new CategoriaNegocio();
                ListaCategorias = cat.listar();
                dgvListarCategorias.DataSource = ListaCategorias;

           
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            frmEditarCategoria formEditarCategoria = new frmEditarCategoria();
            formEditarCategoria.ShowDialog();

        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            frmEliminarCategoria formEliminarCategoria = new frmEliminarCategoria();
            formEliminarCategoria.ShowDialog();
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
