namespace FRONT
{
    partial class BUSCAR_Cobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BUSCAR_Cobros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonIR = new System.Windows.Forms.Button();
            this.buttonBORRAR = new System.Windows.Forms.Button();
            this.buttonEDITAR = new System.Windows.Forms.Button();
            this.buttonABRIR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 70);
            this.panel1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(942, 6);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(188, 58);
            this.button5.TabIndex = 61;
            this.button5.Text = "CERRAR";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(125, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "| LOCALIZADOR DE COBROS";
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
            this.uC_DGV1.Location = new System.Drawing.Point(81, 221);
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(970, 389);
            this.uC_DGV1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 34);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBox1.Location = new System.Drawing.Point(623, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(302, 33);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "TODOS LOS COBROS";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonIR
            // 
            this.buttonIR.BackColor = System.Drawing.Color.LightGray;
            this.buttonIR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonIR.FlatAppearance.BorderSize = 3;
            this.buttonIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonIR.Location = new System.Drawing.Point(970, 153);
            this.buttonIR.Name = "buttonIR";
            this.buttonIR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonIR.Size = new System.Drawing.Size(81, 58);
            this.buttonIR.TabIndex = 57;
            this.buttonIR.Text = "IR";
            this.buttonIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIR.UseVisualStyleBackColor = false;
            this.buttonIR.Click += new System.EventHandler(this.buttonIR_Click);
            // 
            // buttonBORRAR
            // 
            this.buttonBORRAR.BackColor = System.Drawing.Color.LightGray;
            this.buttonBORRAR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonBORRAR.FlatAppearance.BorderSize = 3;
            this.buttonBORRAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonBORRAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonBORRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBORRAR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonBORRAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonBORRAR.Image")));
            this.buttonBORRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBORRAR.Location = new System.Drawing.Point(777, 643);
            this.buttonBORRAR.Name = "buttonBORRAR";
            this.buttonBORRAR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonBORRAR.Size = new System.Drawing.Size(274, 58);
            this.buttonBORRAR.TabIndex = 60;
            this.buttonBORRAR.Text = "BORRAR";
            this.buttonBORRAR.UseVisualStyleBackColor = false;
            this.buttonBORRAR.Click += new System.EventHandler(this.buttonBORRAR_Click);
            // 
            // buttonEDITAR
            // 
            this.buttonEDITAR.BackColor = System.Drawing.Color.LightGray;
            this.buttonEDITAR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonEDITAR.FlatAppearance.BorderSize = 3;
            this.buttonEDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDITAR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonEDITAR.Image")));
            this.buttonEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEDITAR.Location = new System.Drawing.Point(430, 643);
            this.buttonEDITAR.Name = "buttonEDITAR";
            this.buttonEDITAR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonEDITAR.Size = new System.Drawing.Size(274, 58);
            this.buttonEDITAR.TabIndex = 59;
            this.buttonEDITAR.Text = "EDITAR";
            this.buttonEDITAR.UseVisualStyleBackColor = false;
            this.buttonEDITAR.Click += new System.EventHandler(this.buttonEDITAR_Click);
            // 
            // buttonABRIR
            // 
            this.buttonABRIR.BackColor = System.Drawing.Color.LightGray;
            this.buttonABRIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonABRIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonABRIR.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.buttonABRIR.FlatAppearance.BorderSize = 3;
            this.buttonABRIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonABRIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonABRIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonABRIR.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonABRIR.Image = ((System.Drawing.Image)(resources.GetObject("buttonABRIR.Image")));
            this.buttonABRIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonABRIR.Location = new System.Drawing.Point(83, 643);
            this.buttonABRIR.Name = "buttonABRIR";
            this.buttonABRIR.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonABRIR.Size = new System.Drawing.Size(274, 58);
            this.buttonABRIR.TabIndex = 58;
            this.buttonABRIR.Text = "ABRIR";
            this.buttonABRIR.UseVisualStyleBackColor = false;
            this.buttonABRIR.Click += new System.EventHandler(this.buttonABRIR_Click);
            // 
            // BUSCAR_Cobros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 823);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBORRAR);
            this.Controls.Add(this.buttonEDITAR);
            this.Controls.Add(this.buttonABRIR);
            this.Controls.Add(this.buttonIR);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.uC_DGV1);
            this.Controls.Add(this.panel1);
            this.Name = "BUSCAR_Cobros";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonIR;
        private System.Windows.Forms.Button buttonBORRAR;
        private System.Windows.Forms.Button buttonEDITAR;
        private System.Windows.Forms.Button buttonABRIR;
        private System.Windows.Forms.Button button5;
    }
}