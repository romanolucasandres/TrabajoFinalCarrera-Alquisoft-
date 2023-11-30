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
    public partial class UC_cmbTipoEmpleado : UserControl
    {

        public UC_cmbTipoEmpleado()
        {
            InitializeComponent();
        }

        public const string _Gerente = "Gerente";
        public const string _Administrativo = "Administrativo";
        public const string _Vendedor = "Vendedor";
        public const string _Generico = "Generico";

        public string Gerente { get => _Gerente; }
        public string Administrativo { get => _Administrativo; }
        public string Profesor { get => _Vendedor; }
        public string Generico { get => _Generico; }

        public string SeleccionarTipoEmpleado { get => cmbTipoEmpleado.SelectedItem.ToString(); set => cmbTipoEmpleado.SelectedItem = value; }

        private void CargarCombo()
        {
            cmbTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEmpleado.DataSource = TiposEmpleados();
            cmbTipoEmpleado.SelectedIndex = 0;
        }

        private List<string> TiposEmpleados()
        {
            List<string> ListaE = new List<string>();

            ListaE.Add(_Gerente);
            ListaE.Add(_Administrativo);
            ListaE.Add(_Vendedor);
            ListaE.Add(_Generico);

            return ListaE;

        }
    }
}
