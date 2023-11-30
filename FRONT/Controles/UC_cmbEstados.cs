using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT.Controles
{
    public partial class UC_cmbEstados : UserControl
    {
        public UC_cmbEstados()
        {
            InitializeComponent();
            CargarCombo();
        }

        public string SeleccionarEstado { get => comboBox1.SelectedItem.ToString().Trim(); set => comboBox1.SelectedItem = value; }

        private void CargarCombo()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = Estado();
            comboBox1.SelectedIndex = 0;
        }

        private List<string> Estado()
        {
            List<string> LE = new List<string>();
            LE.Add("Disponible");
            LE.Add("No Disponible");


            return LE;

        }

        public bool DevolverEstado()
        {
            if (comboBox1.SelectedItem.ToString().Trim() == "Disponible")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Seleccionar(string s)
        {
            if (s.Trim() == "True")
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (s.Trim() == "False")
            {
                comboBox1.SelectedIndex = 1;
            }

        }
    }
}
