
namespace tp_winform_equipo_14B
{
    partial class frmListarMarcas
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
            this.lblTituloListarMarcas = new System.Windows.Forms.Label();
            this.dgwListarMarcas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloListarMarcas
            // 
            this.lblTituloListarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloListarMarcas.AutoSize = true;
            this.lblTituloListarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListarMarcas.Location = new System.Drawing.Point(12, 83);
            this.lblTituloListarMarcas.Name = "lblTituloListarMarcas";
            this.lblTituloListarMarcas.Size = new System.Drawing.Size(422, 31);
            this.lblTituloListarMarcas.TabIndex = 0;
            this.lblTituloListarMarcas.Text = "Listado De Marcas Registradas";
            // 
            // dgwListarMarcas
            // 
            this.dgwListarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwListarMarcas.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgwListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListarMarcas.Location = new System.Drawing.Point(44, 177);
            this.dgwListarMarcas.Name = "dgwListarMarcas";
            this.dgwListarMarcas.Size = new System.Drawing.Size(352, 150);
            this.dgwListarMarcas.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(161, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwListarMarcas);
            this.Controls.Add(this.lblTituloListarMarcas);
            this.MaximumSize = new System.Drawing.Size(696, 489);
            this.MinimumSize = new System.Drawing.Size(463, 489);
            this.Name = "frmListarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarMarcas";
            this.Load += new System.EventHandler(this.frmListarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListarMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloListarMarcas;
        private System.Windows.Forms.DataGridView dgwListarMarcas;
        private System.Windows.Forms.Button button1;
    }
}