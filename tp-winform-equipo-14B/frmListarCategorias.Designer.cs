﻿namespace tp_winform_equipo_14B
{
    partial class frmListarCategorias
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
            this.lblTituloListarCategorias = new System.Windows.Forms.Label();
            this.dgvListarCategorias = new System.Windows.Forms.DataGridView();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloListarCategorias
            // 
            this.lblTituloListarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloListarCategorias.AutoSize = true;
            this.lblTituloListarCategorias.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTituloListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListarCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTituloListarCategorias.Location = new System.Drawing.Point(22, 14);
            this.lblTituloListarCategorias.Name = "lblTituloListarCategorias";
            this.lblTituloListarCategorias.Size = new System.Drawing.Size(293, 31);
            this.lblTituloListarCategorias.TabIndex = 0;
            this.lblTituloListarCategorias.Text = "Listado de categorias";
            this.lblTituloListarCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvListarCategorias
            // 
            this.dgvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCategorias.Location = new System.Drawing.Point(37, 80);
            this.dgvListarCategorias.Name = "dgvListarCategorias";
            this.dgvListarCategorias.Size = new System.Drawing.Size(258, 283);
            this.dgvListarCategorias.TabIndex = 1;
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(27, 390);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(82, 39);
            this.btnModificarCat.TabIndex = 2;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(124, 390);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(81, 39);
            this.btnEliminarCat.TabIndex = 3;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(221, 390);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(82, 39);
            this.btnCancelarCat.TabIndex = 4;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            // 
            // frmListarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 444);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnModificarCat);
            this.Controls.Add(this.dgvListarCategorias);
            this.Controls.Add(this.lblTituloListarCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarCategorias";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarCategorias";
            this.Load += new System.EventHandler(this.frmListarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloListarCategorias;
        private System.Windows.Forms.DataGridView dgvListarCategorias;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnCancelarCat;
    }
}