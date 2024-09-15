
namespace tp_winform_equipo_14B
{
    partial class frmModificarMarca
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
            this.lblModificarMarca = new System.Windows.Forms.Label();
            this.lblNuevaDescripcion = new System.Windows.Forms.Label();
            this.txtNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptarCambio = new System.Windows.Forms.Button();
            this.dgvModificarMarca = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificarMarca
            // 
            this.lblModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModificarMarca.AutoSize = true;
            this.lblModificarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarMarca.Location = new System.Drawing.Point(121, 78);
            this.lblModificarMarca.Name = "lblModificarMarca";
            this.lblModificarMarca.Size = new System.Drawing.Size(221, 31);
            this.lblModificarMarca.TabIndex = 0;
            this.lblModificarMarca.Text = "Modificar Marca";
            // 
            // lblNuevaDescripcion
            // 
            this.lblNuevaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuevaDescripcion.AutoSize = true;
            this.lblNuevaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaDescripcion.Location = new System.Drawing.Point(12, 155);
            this.lblNuevaDescripcion.Name = "lblNuevaDescripcion";
            this.lblNuevaDescripcion.Size = new System.Drawing.Size(152, 16);
            this.lblNuevaDescripcion.TabIndex = 1;
            this.lblNuevaDescripcion.Text = "Nueva Descripción : ";
            // 
            // txtNuevaDescripcion
            // 
            this.txtNuevaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuevaDescripcion.Location = new System.Drawing.Point(170, 155);
            this.txtNuevaDescripcion.Name = "txtNuevaDescripcion";
            this.txtNuevaDescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtNuevaDescripcion.TabIndex = 2;
            // 
            // btnAceptarCambio
            // 
            this.btnAceptarCambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptarCambio.FlatAppearance.BorderSize = 2;
            this.btnAceptarCambio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAceptarCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCambio.Location = new System.Drawing.Point(170, 206);
            this.btnAceptarCambio.Name = "btnAceptarCambio";
            this.btnAceptarCambio.Size = new System.Drawing.Size(111, 31);
            this.btnAceptarCambio.TabIndex = 3;
            this.btnAceptarCambio.Text = "Aceptar";
            this.btnAceptarCambio.UseVisualStyleBackColor = true;
            this.btnAceptarCambio.Click += new System.EventHandler(this.btnAceptarCambio_Click);
            // 
            // dgvModificarMarca
            // 
            this.dgvModificarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModificarMarca.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvModificarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarMarca.Location = new System.Drawing.Point(65, 243);
            this.dgvModificarMarca.Name = "dgvModificarMarca";
            this.dgvModificarMarca.Size = new System.Drawing.Size(352, 162);
            this.dgvModificarMarca.TabIndex = 4;
            this.dgvModificarMarca.SelectionChanged += new System.EventHandler(this.dgvModificarMarca_SelectionChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(170, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 45);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvModificarMarca);
            this.Controls.Add(this.btnAceptarCambio);
            this.Controls.Add(this.txtNuevaDescripcion);
            this.Controls.Add(this.lblNuevaDescripcion);
            this.Controls.Add(this.lblModificarMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 688);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 528);
            this.Name = "frmModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarMarca";
            this.Load += new System.EventHandler(this.frmModificarMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarMarca;
        private System.Windows.Forms.Label lblNuevaDescripcion;
        private System.Windows.Forms.TextBox txtNuevaDescripcion;
        private System.Windows.Forms.Button btnAceptarCambio;
        private System.Windows.Forms.DataGridView dgvModificarMarca;
        private System.Windows.Forms.Button btnSalir;
    }
}