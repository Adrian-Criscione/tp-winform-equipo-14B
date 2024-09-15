namespace tp_winform_equipo_14B
{
    partial class frmEditarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListarCategorias = new System.Windows.Forms.DataGridView();
            this.lblTextoIDcatEliminar = new System.Windows.Forms.Label();
            this.lblTituloModifCat = new System.Windows.Forms.Label();
            this.nudNumCatModif = new System.Windows.Forms.NumericUpDown();
            this.lblINuevaDescripcion = new System.Windows.Forms.Label();
            this.txtNuevoNombreCat = new System.Windows.Forms.TextBox();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.btnModificarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCatModif)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarCategorias
            // 
            this.dgvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCategorias.Location = new System.Drawing.Point(109, 132);
            this.dgvListarCategorias.Name = "dgvListarCategorias";
            this.dgvListarCategorias.Size = new System.Drawing.Size(258, 283);
            this.dgvListarCategorias.TabIndex = 5;
            // 
            // lblTextoIDcatEliminar
            // 
            this.lblTextoIDcatEliminar.AutoSize = true;
            this.lblTextoIDcatEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoIDcatEliminar.Location = new System.Drawing.Point(12, 65);
            this.lblTextoIDcatEliminar.Name = "lblTextoIDcatEliminar";
            this.lblTextoIDcatEliminar.Size = new System.Drawing.Size(240, 13);
            this.lblTextoIDcatEliminar.TabIndex = 3;
            this.lblTextoIDcatEliminar.Text = "Ingrese el id de la categoria a modificar :";
            // 
            // lblTituloModifCat
            // 
            this.lblTituloModifCat.AutoSize = true;
            this.lblTituloModifCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModifCat.Location = new System.Drawing.Point(99, 9);
            this.lblTituloModifCat.Name = "lblTituloModifCat";
            this.lblTituloModifCat.Size = new System.Drawing.Size(268, 31);
            this.lblTituloModifCat.TabIndex = 4;
            this.lblTituloModifCat.Text = "Modificar Categoria";
            // 
            // nudNumCatModif
            // 
            this.nudNumCatModif.Location = new System.Drawing.Point(262, 58);
            this.nudNumCatModif.Name = "nudNumCatModif";
            this.nudNumCatModif.Size = new System.Drawing.Size(57, 20);
            this.nudNumCatModif.TabIndex = 0;
            // 
            // lblINuevaDescripcion
            // 
            this.lblINuevaDescripcion.AutoSize = true;
            this.lblINuevaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINuevaDescripcion.Location = new System.Drawing.Point(12, 99);
            this.lblINuevaDescripcion.Name = "lblINuevaDescripcion";
            this.lblINuevaDescripcion.Size = new System.Drawing.Size(244, 13);
            this.lblINuevaDescripcion.TabIndex = 6;
            this.lblINuevaDescripcion.Text = "Ingrese el nombre de la nueva categoria :";
            // 
            // txtNuevoNombreCat
            // 
            this.txtNuevoNombreCat.Location = new System.Drawing.Point(262, 92);
            this.txtNuevoNombreCat.Name = "txtNuevoNombreCat";
            this.txtNuevoNombreCat.Size = new System.Drawing.Size(189, 20);
            this.txtNuevoNombreCat.TabIndex = 1;
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(125, 429);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(87, 39);
            this.btnCancelarCat.TabIndex = 3;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(15, 429);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(82, 39);
            this.btnModificarCat.TabIndex = 2;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnModificarCat_Click);
            // 
            // frmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 484);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnModificarCat);
            this.Controls.Add(this.txtNuevoNombreCat);
            this.Controls.Add(this.lblINuevaDescripcion);
            this.Controls.Add(this.nudNumCatModif);
            this.Controls.Add(this.lblTituloModifCat);
            this.Controls.Add(this.lblTextoIDcatEliminar);
            this.Controls.Add(this.dgvListarCategorias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Categoria";
            this.Load += new System.EventHandler(this.frmEditarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumCatModif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarCategorias;
        private System.Windows.Forms.Label lblTextoIDcatEliminar;
        private System.Windows.Forms.Label lblTituloModifCat;
        private System.Windows.Forms.NumericUpDown nudNumCatModif;
        private System.Windows.Forms.Label lblINuevaDescripcion;
        private System.Windows.Forms.TextBox txtNuevoNombreCat;
        private System.Windows.Forms.Button btnCancelarCat;
        private System.Windows.Forms.Button btnModificarCat;
    }
}