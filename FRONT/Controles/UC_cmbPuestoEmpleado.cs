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
    public partial class UC_cmbPuestoEmpleado : UserControl
    {

        public UC_cmbPuestoEmpleado()
        {
            InitializeComponent();
            CargarCmb();
        }

        public const string _Gerente = "Gerente";
        public const string _Administrativo = "Administrativo";
        public const string _Vendedor = "Vendedor";
        public const string _Generico = "Generico";

        public string Gerente { get => _Gerente; }
        public string Administrativo { get => _Administrativo; }
        public string Vendedor { get => _Vendedor; }
        public string Generico { get => _Generico; }

        public string SeleccionarSectorEmpleado { get => cmbPuestoEmpleado.SelectedItem.ToString(); set => cmbPuestoEmpleado.SelectedItem = value; }

        private void CargarCmb()
        {
            cmbPuestoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuestoEmpleado.DataSource = SectorEmpleados();
            cmbPuestoEmpleado.SelectedIndex = 0;
        }

        private List<string> SectorEmpleados()
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
