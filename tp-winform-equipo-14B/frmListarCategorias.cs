using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_winform_equipo_14B
{
    public partial class frmListarCategorias : Form
    {
        private List<Categoria> ListaCategorias;
        public frmListarCategorias()
        {
            InitializeComponent();
        }

        private void frmListarCategorias_Load(object sender, EventArgs e)
        {
         
                CategoriaNegocio cat = new CategoriaNegocio();
                ListaCategorias = cat.listar();
                dgvListarCategorias.DataSource = ListaCategorias;

           
        }

      
    }
}
