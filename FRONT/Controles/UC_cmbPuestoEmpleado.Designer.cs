namespace FRONT.Controles
{
    partial class UC_cmbPuestoEmpleado
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
            this.cmbPuestoEmpleado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSectorEmpleado
            // 
            this.cmbPuestoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuestoEmpleado.FormattingEnabled = true;
            this.cmbPuestoEmpleado.Location = new System.Drawing.Point(6, 6);
            this.cmbPuestoEmpleado.Name = "cmbSectorEmpleado";
            this.cmbPuestoEmpleado.Size = new System.Drawing.Size(244, 37);
            this.cmbPuestoEmpleado.TabIndex = 0;
            // 
            // UC_cmbSectorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cmbPuestoEmpleado);
            this.Name = "UC_cmbSectorEmpleado";
            this.Size = new System.Drawing.Size(257, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPuestoEmpleado;
    }
}
