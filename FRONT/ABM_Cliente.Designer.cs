namespace FRONT
{
    partial class ABM_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSoloTextoTelefono = new FRONT.Controles.UC_txtSoloNumeros();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoloNumerosDni = new FRONT.Controles.UC_txtSoloNumeros();
            this.txtSoloTextoCiudad = new FRONT.Controles.UC_txtSoloTexto();
            this.txtSoloTextoPais = new FRONT.Controles.UC_txtSoloTexto();
            this.txtSoloTextoApellido = new FRONT.Controles.UC_txtSoloTexto();
            this.txtSoloTextoNombre = new FRONT.Controles.UC_txtSoloTexto();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.txtSoloTextoTelefono);
            this.panel4.Controls.Add(this.uC_DGV1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtSoloNumerosDni);
            this.panel4.Controls.Add(this.txtSoloTextoCiudad);
            this.panel4.Controls.Add(this.txtSoloTextoPais);
            this.panel4.Controls.Add(this.txtSoloTextoApellido);
            this.panel4.Controls.Add(this.txtSoloTextoNombre);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Name = "panel4";
            // 
            // txtSoloTextoTelefono
            // 
            this.txtSoloTextoTelefono.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloTextoTelefono, "txtSoloTextoTelefono");
            this.txtSoloTextoTelefono.MaximoNumeros = 32767;
            this.txtSoloTextoTelefono.Name = "txtSoloTextoTelefono";
            this.txtSoloTextoTelefono.SoloLectura = false;
            this.txtSoloTextoTelefono.Texto = "";
            // 
            // uC_DGV1
            // 
            resources.ApplyResources(this.uC_DGV1, "uC_DGV1");
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.eventoSeleccionado += new System.EventHandler(this.uC_DGV1_eventoSeleccionado);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoloNumerosDni
            // 
            this.txtSoloNumerosDni.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloNumerosDni, "txtSoloNumerosDni");
            this.txtSoloNumerosDni.ForeColor = System.Drawing.Color.Black;
            this.txtSoloNumerosDni.MaximoNumeros = 32767;
            this.txtSoloNumerosDni.Name = "txtSoloNumerosDni";
            this.txtSoloNumerosDni.SoloLectura = false;
            this.txtSoloNumerosDni.Texto = "";
            // 
            // txtSoloTextoCiudad
            // 
            this.txtSoloTextoCiudad.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloTextoCiudad, "txtSoloTextoCiudad");
            this.txtSoloTextoCiudad.ForeColor = System.Drawing.Color.Black;
            this.txtSoloTextoCiudad.Name = "txtSoloTextoCiudad";
            this.txtSoloTextoCiudad.SoloLectura = false;
            this.txtSoloTextoCiudad.Texto = "";
            // 
            // txtSoloTextoPais
            // 
            this.txtSoloTextoPais.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloTextoPais, "txtSoloTextoPais");
            this.txtSoloTextoPais.ForeColor = System.Drawing.Color.Black;
            this.txtSoloTextoPais.Name = "txtSoloTextoPais";
            this.txtSoloTextoPais.SoloLectura = false;
            this.txtSoloTextoPais.Texto = "";
            // 
            // txtSoloTextoApellido
            // 
            this.txtSoloTextoApellido.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloTextoApellido, "txtSoloTextoApellido");
            this.txtSoloTextoApellido.ForeColor = System.Drawing.Color.Black;
            this.txtSoloTextoApellido.Name = "txtSoloTextoApellido";
            this.txtSoloTextoApellido.SoloLectura = false;
            this.txtSoloTextoApellido.Texto = "";
            // 
            // txtSoloTextoNombre
            // 
            this.txtSoloTextoNombre.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtSoloTextoNombre, "txtSoloTextoNombre");
            this.txtSoloTextoNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoloTextoNombre.Name = "txtSoloTextoNombre";
            this.txtSoloTextoNombre.SoloLectura = false;
            this.txtSoloTextoNombre.Texto = "";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Name = "label1";
            // 
            // ABM_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Cliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private Controles.UC_txtSoloNumeros txtSoloNumerosDni;
        private Controles.UC_txtSoloTexto txtSoloTextoCiudad;
        private Controles.UC_txtSoloTexto txtSoloTextoPais;
        private Controles.UC_txtSoloTexto txtSoloTextoApellido;
        private Controles.UC_txtSoloTexto txtSoloTextoNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Controles.UC_DGV uC_DGV1;
        private System.Windows.Forms.Button button4;
        private Controles.UC_txtSoloNumeros txtSoloTextoTelefono;
    }
}