namespace FRONT
{
    partial class BUSCAR_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSCAR_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonir = new System.Windows.Forms.Button();
            this.uC_txtSoloNumeros1 = new FRONT.Controles.UC_txtSoloNumeros();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 9;
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
            this.button4.Location = new System.Drawing.Point(941, 7);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 57;
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
            this.label2.Size = new System.Drawing.Size(580, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "| LOCALIZADOR DE CLIENTES";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(226, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "DNI CLIENTE:";
            // 
            // uC_DGV1
            // 
            this.uC_DGV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_DGV1.ForeColor = System.Drawing.Color.Black;
            this.uC_DGV1.Location = new System.Drawing.Point(78, 183);
            this.uC_DGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(970, 389);
            this.uC_DGV1.TabIndex = 47;
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
            this.button2.Location = new System.Drawing.Point(430, 605);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(274, 58);
            this.button2.TabIndex = 56;
            this.button2.Text = "CTA CTE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
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
            this.button1.Location = new System.Drawing.Point(430, 605);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(274, 58);
            this.button1.TabIndex = 55;
            this.button1.Text = "COBRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonir
            // 
            this.buttonir.BackColor = System.Drawing.Color.LightGray;
            this.buttonir.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonir.FlatAppearance.BorderSize = 3;
            this.buttonir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonir.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonir.Location = new System.Drawing.Point(709, 119);
            this.buttonir.Name = "buttonir";
            this.buttonir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonir.Size = new System.Drawing.Size(81, 58);
            this.buttonir.TabIndex = 58;
            this.buttonir.Text = "IR";
            this.buttonir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonir.UseVisualStyleBackColor = false;
            this.buttonir.Click += new System.EventHandler(this.buttonir_Click);
            // 
            // uC_txtSoloNumeros1
            // 
            this.uC_txtSoloNumeros1.BackColor = System.Drawing.Color.Transparent;
            this.uC_txtSoloNumeros1.Location = new System.Drawing.Point(403, 130);
            this.uC_txtSoloNumeros1.MaximoNumeros = 32767;
            this.uC_txtSoloNumeros1.Name = "uC_txtSoloNumeros1";
            this.uC_txtSoloNumeros1.Size = new System.Drawing.Size(284, 44);
            this.uC_txtSoloNumeros1.SoloLectura = false;
            this.uC_txtSoloNumeros1.TabIndex = 59;
            this.uC_txtSoloNumeros1.Texto = "";
            // 
            // BUSCAR_Cliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 823);
            this.ControlBox = false;
            this.Controls.Add(this.uC_txtSoloNumeros1);
            this.Controls.Add(this.buttonir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_DGV1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BUSCAR_Cliente";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private Controles.UC_DGV uC_DGV1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonir;
        private Controles.UC_txtSoloNumeros uC_txtSoloNumeros1;
    }
}