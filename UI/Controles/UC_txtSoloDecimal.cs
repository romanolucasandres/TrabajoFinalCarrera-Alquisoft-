using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABMClientes.Controles
{
    public partial class UC_txtSoloDecimal : UserControl
    {
        public UC_txtSoloDecimal()
        {
            InitializeComponent();
        }

        public event EventHandler evento;
        public bool SoloLectura { get => txtSoloDecimal.ReadOnly; set => txtSoloDecimal.ReadOnly = value; }
        public string Texto { get => txtSoloDecimal.Text; set => txtSoloDecimal.Text = value; }

        public bool Validar()
        {

            if (string.IsNullOrEmpty(txtSoloDecimal.Text) || txtSoloDecimal.Text.ToString().Trim() == "0")
            {
                txtSoloDecimal.Text = string.Empty;
                return false;
            }
            else
                return true;


        }

        public void VaciarTexto()
        {
            txtSoloDecimal.Text = string.Empty;
        }

        public decimal ObtenerValorDecimal()
        {

            try
            {
                decimal.TryParse(txtSoloDecimal.Text, out decimal valor);
                return valor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtSoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && ((TextBox)sender).Text.Contains(",") && ((TextBox)sender).Text.Substring(((TextBox)sender).Text.IndexOf(",")).Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void txtSoloDecimal_TextChanged(object sender, EventArgs e)
        {
            evento?.Invoke(null, new EventArgs());
        }
    }
}
