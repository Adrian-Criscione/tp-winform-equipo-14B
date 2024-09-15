namespace tp_winform_equipo_14B
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArtículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListarMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMarcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgregarArticulo,
            this.buscarArtículoToolStripMenuItem,
            this.listarArtículosToolStripMenuItem,
            this.modificarArtículoToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem,
            this.eliminarArtículoToolStripMenuItem1});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "&Articulos";
            // 
            // menuAgregarArticulo
            // 
            this.menuAgregarArticulo.Name = "menuAgregarArticulo";
            this.menuAgregarArticulo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuAgregarArticulo.Size = new System.Drawing.Size(210, 22);
            this.menuAgregarArticulo.Text = "Agregar Artículo";
            this.menuAgregarArticulo.Click += new System.EventHandler(this.menuAgregarArticulo_Click);
            // 
            // buscarArtículoToolStripMenuItem
            // 
            this.buscarArtículoToolStripMenuItem.Name = "buscarArtículoToolStripMenuItem";
            this.buscarArtículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.buscarArtículoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.buscarArtículoToolStripMenuItem.Text = "Buscar Artículo";
            // 
            // listarArtículosToolStripMenuItem
            // 
            this.listarArtículosToolStripMenuItem.Name = "listarArtículosToolStripMenuItem";
            this.listarArtículosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.listarArtículosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.listarArtículosToolStripMenuItem.Text = "Listar Artículos";
            this.listarArtículosToolStripMenuItem.Click += new System.EventHandler(this.listarArtículosToolStripMenuItem_Click);
            // 
            // modificarArtículoToolStripMenuItem
            // 
            this.modificarArtículoToolStripMenuItem.Name = "modificarArtículoToolStripMenuItem";
            this.modificarArtículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.modificarArtículoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.modificarArtículoToolStripMenuItem.Text = "Modificar Artículo";
            // 
            // eliminarArtículoToolStripMenuItem
            // 
            this.eliminarArtículoToolStripMenuItem.Name = "eliminarArtículoToolStripMenuItem";
            this.eliminarArtículoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.eliminarArtículoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.eliminarArtículoToolStripMenuItem.Text = "Detalle Artículo";
            // 
            // eliminarArtículoToolStripMenuItem1
            // 
            this.eliminarArtículoToolStripMenuItem1.Name = "eliminarArtículoToolStripMenuItem1";
            this.eliminarArtículoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.eliminarArtículoToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.eliminarArtículoToolStripMenuItem1.Text = "Eliminar Artículo";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgregarMarca,
            this.menuListarMarcas});
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.marcasToolStripMenuItem.Text = "&Marcas";
            // 
            // menuAgregarMarca
            // 
            this.menuAgregarMarca.Name = "menuAgregarMarca";
            this.menuAgregarMarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuAgregarMarca.Size = new System.Drawing.Size(194, 22);
            this.menuAgregarMarca.Text = "Agregar Marca";
            this.menuAgregarMarca.Click += new System.EventHandler(this.menuAgregarMarca_Click);
            // 
            // menuListarMarcas
            // 
            this.menuListarMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarMarcaToolStripMenuItem1,
            this.eliminarMarcaToolStripMenuItem1});
            this.menuListarMarcas.Name = "menuListarMarcas";
            this.menuListarMarcas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuListarMarcas.Size = new System.Drawing.Size(194, 22);
            this.menuListarMarcas.Text = "Listar Marcas";
            this.menuListarMarcas.Click += new System.EventHandler(this.menuListarMarcas_Click);
            // 
            // modificarMarcaToolStripMenuItem1
            // 
            this.modificarMarcaToolStripMenuItem1.Name = "modificarMarcaToolStripMenuItem1";
            this.modificarMarcaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.modificarMarcaToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.modificarMarcaToolStripMenuItem1.Text = "Modificar Marca";
            this.modificarMarcaToolStripMenuItem1.Click += new System.EventHandler(this.modificarMarcaToolStripMenuItem1_Click);
            // 
            // eliminarMarcaToolStripMenuItem1
            // 
            this.eliminarMarcaToolStripMenuItem1.Name = "eliminarMarcaToolStripMenuItem1";
            this.eliminarMarcaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.eliminarMarcaToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.eliminarMarcaToolStripMenuItem1.Text = "Eliminar Marca";
            this.eliminarMarcaToolStripMenuItem1.Click += new System.EventHandler(this.eliminarMarcaToolStripMenuItem1_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoríaToolStripMenuItem,
            this.listarCategoríasToolStripMenuItem,
            this.modificarCategoríaToolStripMenuItem,
            this.eliminarCategoríaToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoríasToolStripMenuItem.Text = "&Categorías";
            // 
            // agregarCategoríaToolStripMenuItem
            // 
            this.agregarCategoríaToolStripMenuItem.Name = "agregarCategoríaToolStripMenuItem";
            this.agregarCategoríaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agregarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarCategoríaToolStripMenuItem.Text = "Agregar Categoría";
            this.agregarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoríaToolStripMenuItem_Click);
            // 
            // listarCategoríasToolStripMenuItem
            // 
            this.listarCategoríasToolStripMenuItem.Name = "listarCategoríasToolStripMenuItem";
            this.listarCategoríasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.listarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listarCategoríasToolStripMenuItem.Text = "Listar Categorías";
            this.listarCategoríasToolStripMenuItem.Click += new System.EventHandler(this.listarCategoríasToolStripMenuItem_Click);
            // 
            // modificarCategoríaToolStripMenuItem
            // 
            this.modificarCategoríaToolStripMenuItem.Name = "modificarCategoríaToolStripMenuItem";
            this.modificarCategoríaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.modificarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.modificarCategoríaToolStripMenuItem.Text = "Modificar Categoría";
            this.modificarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoríaToolStripMenuItem_Click);
            // 
            // eliminarCategoríaToolStripMenuItem
            // 
            this.eliminarCategoríaToolStripMenuItem.Name = "eliminarCategoríaToolStripMenuItem";
            this.eliminarCategoríaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.eliminarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eliminarCategoríaToolStripMenuItem.Text = "Eliminar Categoría";
            this.eliminarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCategoríaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 577);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 616);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 616);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarArticulo;
        private System.Windows.Forms.ToolStripMenuItem buscarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArtículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem menuListarMarcas;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMarcaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem1;
    }
}

