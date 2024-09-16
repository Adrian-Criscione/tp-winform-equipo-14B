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
    public partial class frmEliminarCategoria : Form
    {
        private List<Categoria> ListCatElim;

        public frmEliminarCategoria()
        {
            InitializeComponent();
        }

        private void frmEliminarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio cat = new CategoriaNegocio();
            ListCatElim = cat.listar();
            dgvListarCategoriasElim.DataSource = ListCatElim;
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dgvListarCategoriasElim.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            int idCategoria = (int)dgvListarCategoriasElim.SelectedRows[0].Cells["Id"].Value;
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar esta categoría?","Confirmar eliminación",MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    CategoriaNegocio catNegocio = new CategoriaNegocio();
                    //
                    if (catNegocio.ExisteCategoria(idCategoria))
                    {
                        MessageBox.Show("La categoría esta en uso. No se puede borrar.");
                        return;
                    }
                    //
                    catNegocio.eliminarCategoria(idCategoria);

                    ListCatElim = catNegocio.listar();
                    dgvListarCategoriasElim.DataSource = ListCatElim;

                    MessageBox.Show("Categoría eliminada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar la categoría: " + ex.Message);
                }
            }
        }

        private void btnCancelarCatElim_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}