﻿using System;
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
    public partial class frmListarMarcas : Form
    {
        private List<Marca> ListaMarcas;

        public frmListarMarcas()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListarMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            ListaMarcas = marca.listar();
            dgvListarMarcas.DataSource = ListaMarcas;
           
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarMarca ventana = new frmModificarMarca();
            ventana.ShowDialog(); 
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            frmEliminarMarca ventana = new frmEliminarMarca();
            ventana.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
