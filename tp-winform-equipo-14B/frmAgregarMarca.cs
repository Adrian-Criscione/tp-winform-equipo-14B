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

        private bool validarDescripcion()
        {
            if (string.IsNullOrEmpty(txtDescripcionMarca.Text))
            {
                MessageBox.Show("El campo descripción no puede estar vacío");
                return true;
            }

            return false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevaM = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            List<Marca> listaMarcas = new List<Marca>();
            listaMarcas = negocio.listar();
            try
            {
                nuevaM.Descripcion = txtDescripcionMarca.Text;
                if (validarDescripcion())
                {
                    return;
                }
                else if (!listaMarcas.Any(m => m.Descripcion.Equals(nuevaM.Descripcion, StringComparison.OrdinalIgnoreCase)))
                {
                    negocio.agregarMarca(nuevaM);
                    MessageBox.Show("Marca agregada con éxito");
                    Close();
                }
                else
                {
                    MessageBox.Show("Marca ya existente, no se aceptan duplicados");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
               
                
            
        }

        
    }
}
