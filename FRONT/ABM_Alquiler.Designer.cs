namespace FRONT
{
    partial class ABM_Alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABM_Alquiler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerIngreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerEgreso = new System.Windows.Forms.DateTimePicker();
            this.radioButtonfacturados = new System.Windows.Forms.RadioButton();
            this.radioButtonnofacturados = new System.Windows.Forms.RadioButton();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.uC_DGV1 = new FRONT.Controles.UC_DGV();
            this.txtSoloNumerosCodigo = new FRONT.Controles.UC_txtSoloNumeros();
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
            this.panel1.TabIndex = 3;
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
            this.button4.Location = new System.Drawing.Point(933, 6);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(188, 58);
            this.button4.TabIndex = 60;
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
            this.label2.Size = new System.Drawing.Size(534, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "| GESTIÓN DE ALQUILERES";
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
            this.button3.Location = new System.Drawing.Point(763, 321);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(274, 58);
            this.button3.TabIndex = 40;
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
            this.button2.Location = new System.Drawing.Point(416, 321);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(274, 58);
            this.button2.TabIndex = 39;
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
            this.button1.Location = new System.Drawing.Point(69, 321);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(274, 58);
            this.button1.TabIndex = 38;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(146, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.DropDownWidth = 244;
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(190, 182);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(282, 37);
            this.comboBoxCliente.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(62, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "CLIENTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(636, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "UNIDAD:";
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidad.DropDownWidth = 244;
            this.comboBoxUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Location = new System.Drawing.Point(755, 118);
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.Size = new System.Drawing.Size(282, 37);
            this.comboBoxUnidad.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(586, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "VENDEDOR:";
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVendedor.DropDownWidth = 244;
            this.comboBoxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(755, 179);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(282, 37);
            this.comboBoxVendedor.TabIndex = 48;
            // 
            // dateTimePickerIngreso
            // 
            this.dateTimePickerIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.dateTimePickerIngreso.Location = new System.Drawing.Point(190, 249);
            this.dateTimePickerIngreso.Name = "dateTimePickerIngreso";
            this.dateTimePickerIngreso.Size = new System.Drawing.Size(345, 30);
            this.dateTimePickerIngreso.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(54, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "INGRESO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(583, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "EGRESO:";
            // 
            // dateTimePickerEgreso
            // 
            this.dateTimePickerEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.dateTimePickerEgreso.Location = new System.Drawing.Point(707, 249);
            this.dateTimePickerEgreso.Name = "dateTimePickerEgreso";
            this.dateTimePickerEgreso.Size = new System.Drawing.Size(345, 30);
            this.dateTimePickerEgreso.TabIndex = 55;
            // 
            // radioButtonfacturados
            // 
            this.radioButtonfacturados.AutoSize = true;
            this.radioButtonfacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonfacturados.Location = new System.Drawing.Point(190, 396);
            this.radioButtonfacturados.Name = "radioButtonfacturados";
            this.radioButtonfacturados.Size = new System.Drawing.Size(184, 30);
            this.radioButtonfacturados.TabIndex = 56;
            this.radioButtonfacturados.TabStop = true;
            this.radioButtonfacturados.Text = "FACTURADOS";
            this.radioButtonfacturados.UseVisualStyleBackColor = true;
            // 
            // radioButtonnofacturados
            // 
            this.radioButtonnofacturados.AutoSize = true;
            this.radioButtonnofacturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonnofacturados.Location = new System.Drawing.Point(427, 396);
            this.radioButtonnofacturados.Name = "radioButtonnofacturados";
            this.radioButtonnofacturados.Size = new System.Drawing.Size(223, 30);
            this.radioButtonnofacturados.TabIndex = 57;
            this.radioButtonnofacturados.TabStop = true;
            this.radioButtonnofacturados.Text = "NO FACTURADOS";
            this.radioButtonnofacturados.UseVisualStyleBackColor = true;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTodos.Location = new System.Drawing.Point(707, 396);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(305, 30);
            this.radioButtonTodos.TabIndex = 58;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "TODOS LOS ALQUILERES";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(62, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "FILTRAR:";
            // 
            // uC_DGV1
            // 
            this.uC_DGV1.AutoSize = true;
            this.uC_DGV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_DGV1.ForeColor = System.Drawing.Color.Black;
            this.uC_DGV1.Location = new System.Drawing.Point(67, 435);
            this.uC_DGV1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_DGV1.ModoSeleccion = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.uC_DGV1.Multiseleccion = true;
            this.uC_DGV1.Name = "uC_DGV1";
            this.uC_DGV1.Size = new System.Drawing.Size(970, 389);
            this.uC_DGV1.TabIndex = 54;
            // 
            // txtSoloNumerosCodigo
            // 
            this.txtSoloNumerosCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtSoloNumerosCodigo.Location = new System.Drawing.Point(191, 118);
            this.txtSoloNumerosCodigo.MaximoNumeros = 32767;
            this.txtSoloNumerosCodigo.Name = "txtSoloNumerosCodigo";
            this.txtSoloNumerosCodigo.Size = new System.Drawing.Size(284, 44);
            this.txtSoloNumerosCodigo.SoloLectura = true;
            this.txtSoloNumerosCodigo.TabIndex = 47;
            this.txtSoloNumerosCodigo.Texto = "";
            // 
            // ABM_Alquiler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1136, 831);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.radioButtonnofacturados);
            this.Controls.Add(this.radioButtonfacturados);
            this.Controls.Add(this.dateTimePickerEgreso);
            this.Controls.Add(this.uC_DGV1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.txtSoloNumerosCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Alquiler";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private Controles.UC_txtSoloNumeros txtSoloNumerosCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Controles.UC_DGV uC_DGV1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEgreso;
        private System.Windows.Forms.RadioButton radioButtonfacturados;
        private System.Windows.Forms.RadioButton radioButtonnofacturados;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}