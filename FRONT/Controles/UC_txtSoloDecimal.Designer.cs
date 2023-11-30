namespace FRONT.Controles
{
    partial class UC_txtSoloDecimal
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
            this.txtSoloDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSoloDecimal
            // 
            this.txtSoloDecimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoloDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoloDecimal.Location = new System.Drawing.Point(5, 5);
            this.txtSoloDecimal.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoloDecimal.Name = "txtSoloDecimal";
            this.txtSoloDecimal.Size = new System.Drawing.Size(273, 27);
            this.txtSoloDecimal.TabIndex = 2;
            this.txtSoloDecimal.TextChanged += new System.EventHandler(this.txtSoloDecimal_TextChanged);
            this.txtSoloDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloDecimal_KeyPress);
            // 
            // UC_txtSoloDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtSoloDecimal);
            this.Name = "UC_txtSoloDecimal";
            this.Size = new System.Drawing.Size(284, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoloDecimal;
    }
}
