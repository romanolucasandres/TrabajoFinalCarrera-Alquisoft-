namespace FRONT
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonINGRESAR = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSALIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(271, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° LEGAJO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(228, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(431, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(226, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(198, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "BIENVENIDA/O A ALQUISOFT";
            // 
            // buttonINGRESAR
            // 
            this.buttonINGRESAR.AutoSize = true;
            this.buttonINGRESAR.BackColor = System.Drawing.Color.LightGray;
            this.buttonINGRESAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonINGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonINGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonINGRESAR.FlatAppearance.BorderSize = 3;
            this.buttonINGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonINGRESAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonINGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonINGRESAR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonINGRESAR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonINGRESAR.Location = new System.Drawing.Point(204, 241);
            this.buttonINGRESAR.Name = "buttonINGRESAR";
            this.buttonINGRESAR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonINGRESAR.Size = new System.Drawing.Size(164, 37);
            this.buttonINGRESAR.TabIndex = 41;
            this.buttonINGRESAR.Text = "INGRESAR";
            this.buttonINGRESAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonINGRESAR.UseVisualStyleBackColor = false;
            this.buttonINGRESAR.Click += new System.EventHandler(this.buttonINGRESAR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 37);
            this.comboBox1.TabIndex = 43;
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.AutoSize = true;
            this.buttonSALIR.BackColor = System.Drawing.Color.LightGray;
            this.buttonSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSALIR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonSALIR.FlatAppearance.BorderSize = 3;
            this.buttonSALIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSALIR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSALIR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSALIR.Location = new System.Drawing.Point(491, 241);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonSALIR.Size = new System.Drawing.Size(164, 37);
            this.buttonSALIR.TabIndex = 44;
            this.buttonSALIR.Text = "SALIR   ";
            this.buttonSALIR.UseVisualStyleBackColor = false;
            this.buttonSALIR.Click += new System.EventHandler(this.buttonSALIR_Click_1);
            // 
            // LOGIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(754, 314);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonINGRESAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonINGRESAR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSALIR;
    }
}