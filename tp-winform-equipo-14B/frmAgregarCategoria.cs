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
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Categoria newcat = new Categoria();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {

                string categoria = string.IsNullOrWhiteSpace(txtNombreCategoria.Text) ? null : txtNombreCategoria.Text;

                if (categoria == null)
                {
                    MessageBox.Show("La categoría no puede estar vacía.");
                    return;
                }

                bool esNumero = categoria.All(char.IsDigit);
                if (esNumero)
                {
                    MessageBox.Show("La categoría no puede ser solo números.");
                    return;
                }

                newcat.Descripcion = categoria;
                categoriaNegocio.agregarCategoria(newcat);
                MessageBox.Show("Categoría agregada con éxito");

                DialogResult resultado = MessageBox.Show("¿Desea agregar otra categoría?", "Agregar otra", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    txtNombreCategoria.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
