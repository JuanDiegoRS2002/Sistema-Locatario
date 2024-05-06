namespace Sistema_Locatario
{
    partial class Consultar_FrutasyVerduras
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
            this.DTGF = new System.Windows.Forms.DataGridView();
            this.IdFrutaVerdura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMayoreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioMenudeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciasKG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGF)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGF
            // 
            this.DTGF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFrutaVerdura,
            this.IdCategoria,
            this.Nombre,
            this.PrecioMayoreo,
            this.PrecioMenudeo,
            this.ExistenciasKG});
            this.DTGF.Location = new System.Drawing.Point(12, 12);
            this.DTGF.Name = "DTGF";
            this.DTGF.Size = new System.Drawing.Size(648, 407);
            this.DTGF.TabIndex = 30;
            this.DTGF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGF_CellContentClick);
            // 
            // IdFrutaVerdura
            // 
            this.IdFrutaVerdura.HeaderText = "IdFrutaVerdura";
            this.IdFrutaVerdura.Name = "IdFrutaVerdura";
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioMayoreo
            // 
            this.PrecioMayoreo.HeaderText = "PrecioMayoreo";
            this.PrecioMayoreo.Name = "PrecioMayoreo";
            // 
            // PrecioMenudeo
            // 
            this.PrecioMenudeo.HeaderText = "PrecioMenudeo";
            this.PrecioMenudeo.Name = "PrecioMenudeo";
            // 
            // ExistenciasKG
            // 
            this.ExistenciasKG.HeaderText = "ExistenciasKG";
            this.ExistenciasKG.Name = "ExistenciasKG";
            // 
            // Consultar_FrutasyVerduras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.DTGF);
            this.Name = "Consultar_FrutasyVerduras";
            this.Text = "Consultar_FrutasyVerduras";
            ((System.ComponentModel.ISupportInitialize)(this.DTGF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFrutaVerdura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMayoreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioMenudeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciasKG;
    }
}