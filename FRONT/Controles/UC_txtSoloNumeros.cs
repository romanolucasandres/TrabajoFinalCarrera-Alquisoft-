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

namespace FRONT.Controles
{
    public partial class UC_txtSoloNumeros : UserControl
    {
        public bool SoloLectura { get => txtSoloNumeros.ReadOnly; set => txtSoloNumeros.ReadOnly = value; }
        public string Texto { get => txtSoloNumeros.Text; set => txtSoloNumeros.Text = value; }
        public int MaximoNumeros { get => txtSoloNumeros.MaxLength; set => txtSoloNumeros.MaxLength = value; }

        public UC_txtSoloNumeros()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            if (!Regex.IsMatch(txtSoloNumeros.Text.ToString().Trim(), "^[0-9]*$") || string.IsNullOrEmpty(txtSoloNumeros.Text) || txtSoloNumeros.Text.ToString().Trim() == "0")
            {

                txtSoloNumeros.Text = string.Empty;
                return false;
            }
            else
                return true;

        }

        public bool ValidarDni()
        {
            if (Regex.IsMatch(txtSoloNumeros.Text.ToString().Trim(), @"^\d{8}$"))
            {
                return true;
            }
            else
            {
                this.txtSoloNumeros.Text = string.Empty;
                return false;
            }

        }

        public int Obtener()
        {
            try
            {
                int.TryParse(this.txtSoloNumeros.Text.Trim(), out int numero);
                return numero;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Vaciar()
        {
            txtSoloNumeros.Text = string.Empty;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
