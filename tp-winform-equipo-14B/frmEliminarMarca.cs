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
           /* Marca seleccionada = new Marca();
            MarcaNegocio marca = new MarcaNegocio();
            
            try
            {
                if (seleccionada.Id != 0)
                {
                    seleccionada = (Marca)dgvEliminarMarca.CurrentRow.DataBoundItem;
                    marca.eliminarMarca(seleccionada.Id);
                    MessageBox.Show("Operación Exitosa");
                }

                listaMarcasEliminar = marca.listar();
                dgvEliminarMarca.DataSource = listaMarcasEliminar;

    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }*/
           

        }
      
    }
}
