using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABMClientes.Controles
{
    public partial class UC_txtSoloTexto : UserControl
    {
        public UC_txtSoloTexto()
        {
            InitializeComponent();
        }

        public bool SoloLectura { get => txtTexto.ReadOnly; set => txtTexto.ReadOnly = value; }
        public string Texto { get => txtTexto.Text; set => txtTexto.Text = value; }

        public bool Validar()
        {
            if (Regex.IsMatch(txtTexto.Text.ToString().Trim(), @"[a-zA-Z]+$") == false || string.IsNullOrEmpty(txtTexto.Text))
            {
                txtTexto.Text = string.Empty;
                return false;
            }
            else
                return true;

        }
       

        public void VaciarTexto()
        {
            txtTexto.Text = string.Empty;
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
