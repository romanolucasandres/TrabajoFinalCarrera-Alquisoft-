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

namespace ABMClientes.Controles
{
    public partial class UC_txtNumeroyTexto : UserControl
    {
        public UC_txtNumeroyTexto()
        {
            InitializeComponent();
        }
        public bool SoloLectura { get => txtNumeroTexto.ReadOnly; set => txtNumeroTexto.ReadOnly = value; }
        public string Texto { get => txtNumeroTexto.Text; set => txtNumeroTexto.Text = value; }

        public bool Validar()
        {
            if (Regex.IsMatch(txtNumeroTexto.Text.Trim(), @"^[a-zA-Z0-9]+$"))
            {
                return true;
            }
            else
            {
                txtNumeroTexto.Text = string.Empty;
                return false;
            }
        }


        public void VaciarTexto()
        {
            txtNumeroTexto.Text = string.Empty;
        }
    }
}
