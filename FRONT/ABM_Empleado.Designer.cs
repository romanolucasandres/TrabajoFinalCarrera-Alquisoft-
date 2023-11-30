namespace FRONT
{
    partial class ABM_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Empleado));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPuestoEmpleado = new FRONT.Controles.UC_cmbPuestoEmpleado();
            this.label5 = new System.Windows.Forms.Label();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoloNumerosDNI = new FRONT.Controles.UC_txtSoloNumeros();
            this.txtSoloTextoApellido = new FRONT.Controles.UC_txtSoloTexto();
            this.txtSoloTextoNombre = new FRONT.Controles.UC_txtSoloTexto();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.cmbPuestoEmpleado);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.uC_DGV1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtSoloNumerosDNI);
            this.panel4.Controls.Add(this.txtSoloTextoApellido);
            this.panel4.Controls.Add(this.txtSoloTextoNombre);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(2, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1136, 744);
            this.panel4.TabIndex = 27;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmbPuestoEmpleado
            // 
            this.cmbPuestoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.cmbPuestoEmpleado.Location = new System.Drawing.Point(788, 110);
            this.cmbPuestoEmpleado.Name = "cmbPuestoEmpleado";
            this.cmbPuestoEmpleado.SeleccionarSectorEmpleado = "Gerente";
            this.cmbPuestoEmpleado.Size = new System.Drawing.Size(257, 49);
            this.cmbPuestoEmpleado.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(661, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "PUESTO:";
            // 
            // uC_DGV1
            // 
            this.uC_DGV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_DGV1.ForeColor = System.Drawing.Color.Black;
            this.uC_DGV1.Location = new System.Drawing.Point(77, 316);
            this.uC_DGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(970, 389);
            this.uC_DGV1.TabIndex = 38;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.OrangeRed;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(772, 219);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(274, 58);
            this.button3.TabIndex = 37;
            this.button3.Text = "BORRAR";
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
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OrangeRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(425, 219);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(274, 58);
            this.button2.TabIndex = 36;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(78, 219);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(274, 58);
            this.button1.TabIndex = 35;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoloNumerosDNI
            // 
            this.txtSoloNumerosDNI.BackColor = System.Drawing.Color.Transparent;
            this.txtSoloNumerosDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoloNumerosDNI.ForeColor = System.Drawing.Color.Black;
            this.txtSoloNumerosDNI.Location = new System.Drawing.Point(782, 47);
            this.txtSoloNumerosDNI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoloNumerosDNI.MaximoNumeros = 32767;
            this.txtSoloNumerosDNI.Name = "txtSoloNumerosDNI";
            this.txtSoloNumerosDNI.Size = new System.Drawing.Size(279, 44);
            this.txtSoloNumerosDNI.SoloLectura = false;
            this.txtSoloNumerosDNI.TabIndex = 34;
            this.txtSoloNumerosDNI.Texto = "";
            // 
            // txtSoloTextoApellido
            // 
            this.txtSoloTextoApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtSoloTextoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoloTextoApellido.ForeColor = System.Drawing.Color.Black;
            this.txtSoloTextoApellido.Location = new System.Drawing.Point(266, 116);
            this.txtSoloTextoApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoloTextoApellido.Name = "txtSoloTextoApellido";
            this.txtSoloTextoApellido.Size = new System.Drawing.Size(288, 43);
            this.txtSoloTextoApellido.SoloLectura = false;
            this.txtSoloTextoApellido.TabIndex = 30;
            this.txtSoloTextoApellido.Texto = "";
            // 
            // txtSoloTextoNombre
            // 
            this.txtSoloTextoNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtSoloTextoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoloTextoNombre.ForeColor = System.Drawing.Color.Black;
            this.txtSoloTextoNombre.Location = new System.Drawing.Point(266, 50);
            this.txtSoloTextoNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoloTextoNombre.Name = "txtSoloTextoNombre";
            this.txtSoloTextoNombre.Size = new System.Drawing.Size(288, 43);
            this.txtSoloTextoNombre.SoloLectura = false;
            this.txtSoloTextoNombre.TabIndex = 29;
            this.txtSoloTextoNombre.Texto = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(723, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(124, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "APELLIDO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(135, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "NOMBRE:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 70);
            this.panel1.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(937, 7);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 40;
            this.button4.Text = "CERRAR";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "| GESTIÓN DE EMPLEADOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ABM_Empleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 823);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Empleado";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Controles.UC_DGV uC_DGV1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Controles.UC_txtSoloNumeros txtSoloNumerosDNI;
        private Controles.UC_txtSoloTexto txtSoloTextoApellido;
        private Controles.UC_txtSoloTexto txtSoloTextoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Controles.UC_cmbPuestoEmpleado cmbPuestoEmpleado;
        private System.Windows.Forms.Button button4;
    }
}