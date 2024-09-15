
namespace tp_winform_equipo_14B
{
    partial class frmEliminarMarca
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
            this.lblEliminarMarcas = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.dgvEliminarMarca = new System.Windows.Forms.DataGridView();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminarMarcas
            // 
            this.lblEliminarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminarMarcas.AutoSize = true;
            this.lblEliminarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarMarcas.Location = new System.Drawing.Point(112, 90);
            this.lblEliminarMarcas.Name = "lblEliminarMarcas";
            this.lblEliminarMarcas.Size = new System.Drawing.Size(222, 31);
            this.lblEliminarMarcas.TabIndex = 0;
            this.lblEliminarMarcas.Text = "Eliminar Marcas";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.Location = new System.Drawing.Point(76, 167);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(291, 16);
            this.lblLeyenda.TabIndex = 1;
            this.lblLeyenda.Text = "Seleccione la Marca que desee eliminar:";
            // 
            // dgvEliminarMarca
            // 
            this.dgvEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEliminarMarca.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEliminarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarMarca.Location = new System.Drawing.Point(48, 214);
            this.dgvEliminarMarca.Name = "dgvEliminarMarca";
            this.dgvEliminarMarca.Size = new System.Drawing.Size(352, 179);
            this.dgvEliminarMarca.TabIndex = 5;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarMarca.FlatAppearance.BorderSize = 2;
            this.btnEliminarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Location = new System.Drawing.Point(48, 419);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(111, 45);
            this.btnEliminarMarca.TabIndex = 6;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(280, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 499);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.dgvEliminarMarca);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.lblEliminarMarcas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 742);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(472, 538);
            this.Name = "frmEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEliminarMarca";
            this.Load += new System.EventHandler(this.frmEliminarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarMarcas;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.DataGridView dgvEliminarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnCancelar;
    }
}