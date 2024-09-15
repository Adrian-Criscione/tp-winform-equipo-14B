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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        //CONSTRUCTOR PARA PODER MODIFICAAR ARTICULOS
        public frmAgregarArticulo(Articulo articulo)
        {
            
            InitializeComponent();
            this.articulo = articulo;
            //propiedades que se modifican para la ventana de modificar          
            Text = "Modificar Articulo";
            lblAgregarArticulo.Text = "Modificar Articulo";
        }
        public frmAgregarArticulo(Articulo articulo, string botonClickeado)
        {

            InitializeComponent();
            this.articulo = articulo;
            //propiedades que se modifican para la ventana de modificar          
            if(botonClickeado == "Ver Detalle")
            {
                Text = "Detalle Articulo";
                lblAgregarArticulo.Text = "Detalle Articulo";
                btnNuevo.Visible = false;
                btnCancelar.Text = "Volver";
            }
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
            
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                { 
                    articulo = new Articulo();
                }
                  
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarcaArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoriaArticulo.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagen = txtImagen.Text;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo " + txtCodigo.Text + " modificado con éxito");

                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo " + txtCodigo.Text + " agregado con éxito");
                }
                
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
                //SI entra por modificar se cambian estos valores en las props del formulario
                if (lblAgregarArticulo.Text == "Modificar Articulo")
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
                    btnAgregarArticulo.Text = "Modifcar";
                }//fin

                cboMarcaArticulo.DataSource = marcaNegocio.listar();
                cboMarcaArticulo.ValueMember = "Id";
                cboMarcaArticulo.DisplayMember = "Descripcion";

                cboCategoriaArticulo.DataSource = categoriaNegocio.listar();
                cboCategoriaArticulo.ValueMember = "Id";
                cboCategoriaArticulo.DisplayMember = "Descripcion";

                 if(articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.Imagen);
                    
                    //validar que la marca no sea null
                    if(articulo.Marca is null)
                    {
                        cboMarcaArticulo.SelectedValue = "";
                    }
                    else
                    {
                        cboMarcaArticulo.SelectedValue = articulo.Marca.Id;
                    }
                    
                    
                    cboMarcaArticulo.SelectedValue = articulo.Marca.Id;
                    
                    //validar que la categoria no sea null
                    if(articulo.Categoria is null)
                    {
                        cboCategoriaArticulo.SelectedValue = "";
                    }    
                    else
                    {
                        cboCategoriaArticulo.SelectedValue = articulo.Categoria.Id;
                    }
          
                      
                        

                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");

            }
        }
    }
}
