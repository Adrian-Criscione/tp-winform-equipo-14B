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
    public partial class frmEditarCategoria : Form
    {
        private List<Categoria> ListCatAmodif;
        public frmEditarCategoria()
        {
            InitializeComponent();
        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {

            CategoriaNegocio cat = new CategoriaNegocio();
            ListCatAmodif = cat.listar();
            dgvListarCategorias.DataSource = ListCatAmodif;
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = (int)nudNumCatModif.Value;
                string nuevaDescripcion = txtNuevoNombreCat.Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevaDescripcion))
                {
                    MessageBox.Show("La nueva descripción no puede estar vacía.");
                    return;
                }

                bool esSoloNumeros = nuevaDescripcion.All(char.IsDigit);
                if (esSoloNumeros)
                {
                    MessageBox.Show("La nueva descripción no puede ser solo números.");
                    return;
                }

                CategoriaNegocio catNegocio = new CategoriaNegocio();

                if (!catNegocio.ExisteCategoriaPorId(idCategoria))
                {
                    MessageBox.Show("El ID de la categoría no existe.");
                    return;
                }

                if (catNegocio.ExisteCategoria(nuevaDescripcion))
                {
                    MessageBox.Show("Ya existe una categoría con esa descripción.");
                    return;
                }

                Categoria categoriaModificada = new Categoria
                {
                    Id = idCategoria,
                    Descripcion = nuevaDescripcion
                };

                catNegocio.modificarCategoria(categoriaModificada);
                MessageBox.Show("Categoría modificada con éxito.");
                ListCatAmodif = catNegocio.listar();
                dgvListarCategorias.DataSource = ListCatAmodif;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la categoría: " + ex.Message);
            }
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
