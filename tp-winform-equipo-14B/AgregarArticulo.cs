using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace tp_winform_equipo_14B
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregarArticulo.Visible = true;
            btnNuevo.Visible = false;
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            txtImagen.Enabled = true;
            cboCategoriaArticulo.Enabled = true;
            cboMarcaArticulo.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.CodigoArticulo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Marca = (Marca)cboMarcaArticulo.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoriaArticulo.SelectedItem;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.Imagen = txtImagen.Text;

                negocio.agregar(nuevo);

                MessageBox.Show("Articulo " + txtCodigo.Text + " agregado con éxito");
                this.Close();
                
                btnAgregarArticulo.Visible = false;
                btnNuevo.Visible = true;
                txtCodigo.Enabled = false;
                txtNombre.Enabled = false;
                txtDescripcion.Enabled = false;
                txtPrecio.Enabled = false;
                txtImagen.Enabled = false;
                cboCategoriaArticulo.Enabled = false;
                cboMarcaArticulo.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new negocio.CategoriaNegocio();
            
            try
            {
                cboMarcaArticulo.DataSource = marcaNegocio.listar();
                cboCategoriaArticulo.DataSource = categoriaNegocio.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            //TODO: agregar los cbomarca y cbo categorio con la siguiente logica falta agregar los marcaNEgocio y CategoriaNEgocio
            //ElementoNegocio elementoNegocio = new ElementoNegocio();
            //try
            //{
            //    cboTipo.DataSource = elementoNegocio.listar();
            //    cboDebilidad.DataSource = elementoNegocio.listar();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
