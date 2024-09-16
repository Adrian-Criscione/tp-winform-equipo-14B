using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tp_winform_equipo_14B
{
    public partial class frmListarArticulos : Form
    {
        private List<Articulo> ListaArticulo;
        Button botonclickeado;
        public frmListarArticulos()
        {
            InitializeComponent();
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cargarCombos();


        }

        private void cargarCombos()
        {
            // combo box de campo
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");

            // combo box de Criterio
        }
        private void dgvListarArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListarArticulos.CurrentCell != null)
            {
                Articulo seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }

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
                ocultarColumnas();
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
        public string botonClickeado(object sender, EventArgs e)
        {
            botonclickeado = sender as Button;
            if(botonclickeado != null )
            {
                return botonclickeado.Text;
            }
            else
            {
                return string.Empty;
            }
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
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Elimar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
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

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor Seleccione un campo para filtrar");

                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un criterio para filtrar");
                return true;
            }
            
            if(string.IsNullOrEmpty(txtFiltroAvanzado.Text))
            {
                MessageBox.Show("El campo filtro no puede estar vacío");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor ingrese solo números");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }

            return true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvListarArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvListarArticulos.Columns["imagen"].Visible = false;
            dgvListarArticulos.Columns["Id"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = ListaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));// || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulo;
            }



            dgvListarArticulos.DataSource = null;
            dgvListarArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
        
        private void cmdDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvListarArticulos.CurrentRow.DataBoundItem;
            botonclickeado = sender as Button;
            frmAgregarArticulo verArticulo = new frmAgregarArticulo(seleccionado, botonclickeado.Text);
            verArticulo.ShowDialog();
            cargar();
        }
    }
}
