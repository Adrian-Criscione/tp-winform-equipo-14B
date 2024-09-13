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
            cargar();

        }
        private void dgvListarArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void cargar()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            try
            {

                ListaArticulo = articulo.listar();
                dgvListarArticulos.DataSource = ListaArticulo;
                dgvListarArticulos.Columns["imagen"].Visible = false;
                dgvListarArticulos.Columns["Id"].Visible = false;
                pbxArticulo.Load(ListaArticulo[0].Imagen); //sirve para mostrar las imagenes pero se pincha el programa asi que hay que revisarlo por el momento no funcioan.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //seleccionar el articulo para pasarlo al constructor de la clase frmagregarArticulo
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;

            frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(seleccionado);
            modificarArticulo.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Elimar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void metodoPruebaGIT()
        {
            //borrar
        }
    }
}
