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
    public partial class UC_txtTelefono : UserControl
    {
        public UC_txtTelefono()
        {
            InitializeComponent();
        }

        public bool SoloLectura { get => txtTelefono.ReadOnly; set => txtTelefono.ReadOnly = value; }
        public string Texto { get => txtTelefono.Text; set => txtTelefono.Text = value; }

        public bool Validar()
        {
            if (Regex.IsMatch(txtTelefono.Text.ToString().Trim(), "^[0-9]*$") == false || string.IsNullOrEmpty(txtTelefono.Text))
            {
                txtTelefono.Text = string.Empty;
                return false;
            }
            else return true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
