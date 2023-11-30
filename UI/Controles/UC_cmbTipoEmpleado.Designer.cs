namespace ABMClientes.Controles
{
    partial class UC_cmbTipoEmpleado
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
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(6, 6);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(244, 37);
            this.cmbTipoEmpleado.TabIndex = 0;
            // 
            // UC_cmbTipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.cmbTipoEmpleado);
            this.Name = "UC_cmbTipoEmpleado";
            this.Size = new System.Drawing.Size(257, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
    }
}
