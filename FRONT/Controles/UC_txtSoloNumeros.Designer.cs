namespace FRONT.Controles
{
    partial class UC_txtSoloNumeros
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
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoloNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoloNumeros.Location = new System.Drawing.Point(5, 5);
            this.txtSoloNumeros.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(271, 27);
            this.txtSoloNumeros.TabIndex = 1;
            this.txtSoloNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // UC_txtSoloNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtSoloNumeros);
            this.Name = "UC_txtSoloNumeros";
            this.Size = new System.Drawing.Size(323, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoloNumeros;
    }
}
