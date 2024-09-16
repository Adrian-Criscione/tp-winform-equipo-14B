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
    public partial class frmEliminarMarca : Form
    {
        private List<Marca> listaMarcasEliminar;
        private Marca seleccionada;

        public frmEliminarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEliminarMarca_Load(object sender, EventArgs e)
        {

            MarcaNegocio negocioMarca = new MarcaNegocio();
            listaMarcasEliminar = negocioMarca.listar();
            dgvEliminarMarca.DataSource = listaMarcasEliminar;
           
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {

                seleccionada = (Marca)dgvEliminarMarca.CurrentRow.DataBoundItem;
                //
                if (negocioMarca.ExisteMarca(seleccionada.Id))
                {
                    MessageBox.Show("La Marca esta en uso y no se puede borrar.");
                    return;
                }
                //
                if (seleccionada.Id != 0)
                {

                    negocioMarca.eliminarMarca(seleccionada.Id);
                    MessageBox.Show("Operación Exitosa");
                }

                listaMarcasEliminar = negocioMarca.listar();
                dgvEliminarMarca.DataSource = listaMarcasEliminar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }
      
    }
}
