﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class BITACORA_Registros : Form
    {
        public BITACORA_Registros()
        {
            InitializeComponent();    
            listBox1.DataSource = S_Registros.ObtenerDatosArchivo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
