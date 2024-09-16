namespace tp_winform_equipo_14B
{
    partial class frmEliminarCategoria
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
            this.lblTituloElimCat = new System.Windows.Forms.Label();
            this.dgvListarCategoriasElim = new System.Windows.Forms.DataGridView();
            this.btnCancelarCatElim = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategoriasElim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloElimCat
            // 
            this.lblTituloElimCat.AutoSize = true;
            this.lblTituloElimCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloElimCat.Location = new System.Drawing.Point(118, 25);
            this.lblTituloElimCat.Name = "lblTituloElimCat";
            this.lblTituloElimCat.Size = new System.Drawing.Size(254, 31);
            this.lblTituloElimCat.TabIndex = 0;
            this.lblTituloElimCat.Text = "Eliminar Categoria";
            // 
            // dgvListarCategoriasElim
            // 
            this.dgvListarCategoriasElim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCategoriasElim.Location = new System.Drawing.Point(114, 88);
            this.dgvListarCategoriasElim.Name = "dgvListarCategoriasElim";
            this.dgvListarCategoriasElim.Size = new System.Drawing.Size(258, 283);
            this.dgvListarCategoriasElim.TabIndex = 6;
            // 
            // btnCancelarCatElim
            // 
            this.btnCancelarCatElim.Location = new System.Drawing.Point(152, 392);
            this.btnCancelarCatElim.Name = "btnCancelarCatElim";
            this.btnCancelarCatElim.Size = new System.Drawing.Size(87, 39);
            this.btnCancelarCatElim.TabIndex = 8;
            this.btnCancelarCatElim.Text = "Salir";
            this.btnCancelarCatElim.UseVisualStyleBackColor = true;
            this.btnCancelarCatElim.Click += new System.EventHandler(this.btnCancelarCatElim_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(33, 392);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(82, 39);
            this.btnEliminarCat.TabIndex = 7;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // frmEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 459);
            this.Controls.Add(this.btnCancelarCatElim);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.dgvListarCategoriasElim);
            this.Controls.Add(this.lblTituloElimCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar categoria";
            this.Load += new System.EventHandler(this.frmEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategoriasElim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloElimCat;
        private System.Windows.Forms.DataGridView dgvListarCategoriasElim;
        private System.Windows.Forms.Button btnCancelarCatElim;
        private System.Windows.Forms.Button btnEliminarCat;
    }
}