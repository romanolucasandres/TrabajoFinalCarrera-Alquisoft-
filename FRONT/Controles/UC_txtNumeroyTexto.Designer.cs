namespace FRONT.Controles
{
    partial class UC_txtNumeroyTexto
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
            this.txtNumeroTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeroTexto
            // 
            this.txtNumeroTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroTexto.Location = new System.Drawing.Point(5, 5);
            this.txtNumeroTexto.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumeroTexto.Name = "txtNumeroTexto";
            this.txtNumeroTexto.Size = new System.Drawing.Size(273, 27);
            this.txtNumeroTexto.TabIndex = 3;
            this.txtNumeroTexto.TextChanged += new System.EventHandler(this.txtNumeroTexto_TextChanged);
            // 
            // UC_txtNumeroyTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtNumeroTexto);
            this.Name = "UC_txtNumeroyTexto";
            this.Size = new System.Drawing.Size(283, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroTexto;
    }
}
