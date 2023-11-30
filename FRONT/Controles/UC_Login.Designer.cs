namespace FRONT.Controles
{
    partial class UC_Login
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
            this.userControl11 = new FRONT.Controles.UC_Login();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(236, 113);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(485, 150);
            this.userControl11.TabIndex = 0;
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl11);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(485, 254);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UC_Login userControl11;
    }
}
