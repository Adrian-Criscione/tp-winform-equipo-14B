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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.ShowDialog(); //vincula la ventana principal con la ventana de agregar artículo
        }

        private void menuAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.ShowDialog(); //vincula la ventana principal con la ventana agregar marca
        }

        private void agregarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventana = new frmAgregarCategoria();
            ventana.ShowDialog();
        }

        private void listarArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarArticulos ventana = new frmListarArticulos();
            ventana.ShowDialog();
        }

        private void menuListarMarcas_Click(object sender, EventArgs e)
        {
            frmListarMarcas ventana = new frmListarMarcas();
            ventana.ShowDialog();
        }

        private void modificarMarcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModificarMarca ventana = new frmModificarMarca();
            ventana.ShowDialog();

        }

        private void eliminarMarcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminarMarca ventana = new frmEliminarMarca();
            ventana.ShowDialog();
        }

        private void listarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms){

                if (item.GetType() == typeof(frmListarCategorias))
                {
                    return;
                }

            } 
            frmListarCategorias ventana = new frmListarCategorias();           
            ventana.ShowDialog();
        }
    }
}
