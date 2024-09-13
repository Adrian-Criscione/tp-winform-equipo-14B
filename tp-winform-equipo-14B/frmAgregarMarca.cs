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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaM = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                nuevaM.Descripcion = txtDescripcionMarca.Text;
                negocio.agregarMarca(nuevaM);
                MessageBox.Show("Marca agregada con éxito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
               
                
            
        }

        
    }
}
