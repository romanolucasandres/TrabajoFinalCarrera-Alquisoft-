namespace FRONT
{
    partial class CONTROL_CuentaCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONTROL_CuentaCorriente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteBOX = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 7;
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
            this.button4.Location = new System.Drawing.Point(936, 7);
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
            this.label2.Size = new System.Drawing.Size(439, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "| CUENTA CORRIENTE";
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
            // uC_DGV1
            // 
            this.uC_DGV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_DGV1.ForeColor = System.Drawing.Color.Black;
            this.uC_DGV1.Location = new System.Drawing.Point(86, 127);
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(970, 389);
            this.uC_DGV1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // clienteBOX
            // 
            this.clienteBOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clienteBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteBOX.ForeColor = System.Drawing.Color.OrangeRed;
            this.clienteBOX.Location = new System.Drawing.Point(195, 537);
            this.clienteBOX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteBOX.Name = "clienteBOX";
            this.clienteBOX.Size = new System.Drawing.Size(724, 62);
            this.clienteBOX.TabIndex = 10;
            this.clienteBOX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(422, 647);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(238, 69);
            this.labelSaldo.TabIndex = 11;
            this.labelSaldo.Text = "SALDO";
            // 
            // labelClient
            // 
            this.labelClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelClient.Location = new System.Drawing.Point(221, 541);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(674, 53);
            this.labelClient.TabIndex = 12;
            // 
            // CONTROL_CuentaCorriente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 823);
            this.ControlBox = false;
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.clienteBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_DGV1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CONTROL_CuentaCorriente";
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
        private Controles.UC_DGV uC_DGV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clienteBOX;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelClient;
    }
}