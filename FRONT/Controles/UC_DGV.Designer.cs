namespace FRONT.Controles
{
    partial class UC_DGV
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPantallas = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPantallas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPantallas
            // 
            this.dgvPantallas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPantallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPantallas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPantallas.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvPantallas.Location = new System.Drawing.Point(0, 0);
            this.dgvPantallas.Name = "dgvPantallas";
            this.dgvPantallas.RowHeadersWidth = 51;
            this.dgvPantallas.RowTemplate.Height = 24;
            this.dgvPantallas.Size = new System.Drawing.Size(970, 389);
            this.dgvPantallas.TabIndex = 0;
            this.dgvPantallas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPantallas_CellClick);
            // 
            // UC_DGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPantallas);
            this.Name = "UC_DGV";
            this.Size = new System.Drawing.Size(970, 389);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPantallas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPantallas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
