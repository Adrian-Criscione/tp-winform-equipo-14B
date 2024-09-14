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
    public partial class frmModificarMarca : Form
    {
        private List<Marca> listaMarcasModificar;
        private Marca seleccionada ;


        public frmModificarMarca()
        {
            InitializeComponent();
        }

        private void frmModificarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            listaMarcasModificar = negocioMarca.listar();
            dgvModificarMarca.DataSource = listaMarcasModificar;
            
        }

        private void btnAceptarCambio_Click(object sender, EventArgs e)
        {
            
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
              
                seleccionada.Descripcion = txtNuevaDescripcion.Text;
                if(seleccionada.Id !=0)
                {
                    negocioMarca.modificarMarca(seleccionada);
                    MessageBox.Show("Operación Exitosa");
                }
               
                listaMarcasModificar = negocioMarca.listar();
                dgvModificarMarca.DataSource = listaMarcasModificar;

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

          
           
        }

        private void dgvModificarMarca_SelectionChanged(object sender, EventArgs e)
        {
            seleccionada = (Marca)dgvModificarMarca.CurrentRow.DataBoundItem;
        }
    }
}
